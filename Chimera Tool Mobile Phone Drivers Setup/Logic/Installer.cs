using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Text;
using ChimeraToolMobilePhoneDriversSetup.Pages;

namespace ChimeraToolMobilePhoneDriversSetup.Logic
{
    public class Installer
    {
        private string tempDriverExtractDir;
        private InstallingPage installerPage;
        public Installer()
        {
            tempDriverExtractDir = Path.GetTempPath() + @"mobileDriverExtract";

            foreach (Page pg in Form1.Instance.pages)
            {
                try
                {
                    installerPage = (InstallingPage)pg;
                    break;
                }
                catch { continue; }
            }
        }

        public delegate void _installationFinishedDel(object sender, EventArgs e);

        private _installationFinishedDel _installationFinished;
        public event _installationFinishedDel InstallationFinished
        {
            add { _installationFinished += value; }
            remove { _installationFinished -= value; }
        }
        public int InstallProgress = 0;

        public async Task Install()
        {
            byte[] zipFileData = Properties.Resources.drivers_Mobile;
            string extractPath = tempDriverExtractDir;
            if (zipFileData == null || zipFileData.Length == 0)
            {
                throw new ArgumentException("Zip file data cannot be null or empty.", nameof(zipFileData));
            }

            if (string.IsNullOrEmpty(extractPath))
            {
                throw new ArgumentException("Extract path cannot be null or empty.", nameof(extractPath));
            }

            Ext_UpdateStatus("Extracting driver files to temp directory...");
            // Ensure the extraction directory exists.
            Directory.CreateDirectory(extractPath);

            // Use a MemoryStream to treat the byte array as a stream.
            using (MemoryStream memoryStream = new MemoryStream(zipFileData))
            {
                // Use ZipArchive to read the stream.
                using (ZipArchive archive = new ZipArchive(memoryStream, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry[] entries = archive.Entries.ToArray();

                    Ext_UpdateProgressMax(entries.Length);

                    for (int i = 0; i < entries.Length; i++)
                    {
                        ZipArchiveEntry entry = entries[i];

                        // Get the full path of the destination file.
                        string fullPath = Path.Combine(extractPath, entry.FullName);

                        // If the entry is a directory, create it.
                        if (string.IsNullOrEmpty(entry.Name))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
                            continue;
                        }

                        // Ensure the directory for the file exists.
                        Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

                        // Asynchronously extract the file.
                        using (Stream entryStream = entry.Open())
                        using (FileStream fileStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
                        {
                            await entryStream.CopyToAsync(fileStream);
                        }

                        Ext_UpdateDetails("Extracted driver file: " + fullPath);
                        Ext_UpdateProgress(i);

                        await Task.Run(() =>
                        {
                            Thread.Sleep(0);
                        });

                    }
                }
            }

            
            string[] infFiles = Directory.GetFiles(tempDriverExtractDir, "*.inf", SearchOption.AllDirectories);

            Ext_UpdateStatus($"Installing {infFiles.Length.ToString()} drivers...");

            Ext_UpdateProgressMax(infFiles.Length);

            for (int i = 0; i < infFiles.Length; i++)
            {
                Ext_UpdateStatus($"Installing {((infFiles.Length - 1) - i).ToString()} drivers...");

                string output = await InstallDriverAsync(infFiles[i]);
                if (output.Contains("Driver package added successfully"))
                {
                    Ext_UpdateDetails("Successfully Installed driver: " + Path.GetFileName(infFiles[i]));
                }
                else
                {
                    Ext_UpdateDetails("Failed to install driver: " + Path.GetFileName(infFiles[i]));
                }

                // run the actual driver installs here
                Ext_UpdateProgress(i);
            }

            // Cleanup temp dir
            Directory.Delete(tempDriverExtractDir, true);
            Ext_UpdateDetails("Cleaned up temp files..");
            Ext_UpdateDetails("Finished driver installs!");

            Ext_UpdateStatus("Driver installs finished!");

            finishEvent();
        }
        /// <summary>
        /// Asynchronously installs a driver using pnputil.exe and returns the output.
        /// This function requires administrative privileges to run correctly.
        /// </summary>
        /// <param name="infFilePath">The full path to the .inf file for the driver.</param>
        /// <returns>A string containing the standard output and standard error from the pnputil process.</returns>
        /// <exception cref="FileNotFoundException">Thrown if the specified .inf file does not exist.</exception>
        /// <exception cref="InvalidOperationException">Thrown if the process fails to start.</exception>
        private async Task<string> InstallDriverAsync(string infFilePath)
        {
            if (!File.Exists(infFilePath))
            {
                throw new FileNotFoundException("The specified INF file was not found.", infFilePath);
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "pnputil.exe",
                Arguments = $"/add-driver \"{infFilePath}\" /install",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Verb = "runas" // This requests elevation to run as an administrator.
            };

            using (Process process = new Process { StartInfo = processStartInfo })
            {
                var outputBuilder = new StringBuilder();

                // Capture the output asynchronously.
                process.OutputDataReceived += (sender, args) =>
                {
                    if (args.Data != null)
                    {
                        outputBuilder.AppendLine(args.Data);
                    }
                };

                process.ErrorDataReceived += (sender, args) =>
                {
                    if (args.Data != null)
                    {
                        outputBuilder.AppendLine(args.Data);
                    }
                };

                try
                {
                    process.Start();

                    // Begin reading the output streams asynchronously.
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    // Asynchronously wait for the process to exit.
                    await process.WaitForExitAsync();
                }
                catch (Exception ex)
                {
                    // This can happen if the user denies the UAC prompt.
                    throw new InvalidOperationException("Failed to start the pnputil process. Ensure you have administrative privileges.", ex);
                }

                return outputBuilder.ToString();
            }
        }


        private void Ext_UpdateStatus(string status)
        {
            if (Form1.Instance != null)
            {
                if (Form1.Instance.InvokeRequired)
                {
                    Form1.Instance.Invoke(new UpdateEventDels.UpdateStatusDel(Ext_UpdateStatus), status);
                }
                else
                {
                    installerPage.statusLbl.Text = status;
                }
            }
        }

        private void Ext_UpdateProgressMax(int progMax)
        {
            if (Form1.Instance != null)
            {
                if (Form1.Instance.InvokeRequired)
                {
                    Form1.Instance.Invoke(new UpdateEventDels.UpdateProgDel(Ext_UpdateProgress), progMax);
                }
                else
                {
                    InstallProgress += 1;
                    installerPage.progressBar1.Maximum = progMax;
                }
            }
        }

        private void Ext_UpdateProgress(int prog)
        {
            if (Form1.Instance != null)
            {
                if (Form1.Instance.InvokeRequired)
                {
                    Form1.Instance.Invoke(new UpdateEventDels.UpdateProgDel(Ext_UpdateProgress), prog);
                }
                else
                {
                    InstallProgress += 1;
                    installerPage.progressBar1.Value = prog;
                }
            }
        }

        private void Ext_UpdateDetails(string details)
        {
            if (Form1.Instance != null)
            {
                if (Form1.Instance.InvokeRequired)
                {
                    Form1.Instance.Invoke(new UpdateEventDels.UpdateDetailsDel(Ext_UpdateDetails), details);
                }
                else
                {
                    installerPage.detailsBox.Items.Add(details);
                    installerPage.detailsBox.SelectedIndex = installerPage.detailsBox.Items.Count - 1;
                }
            }
        }

        public delegate void finishEventDel();
        private void finishEvent()
        {
            if (Form1.Instance != null)
            {
                if (Form1.Instance.InvokeRequired)
                {
                    Form1.Instance.Invoke(new finishEventDel(finishEvent));
                }
                else
                {
                    if (_installationFinished != null)
                    {
                        Form1.Instance.frmSpinner.Stop();
                        _installationFinished(this, new EventArgs());
                    }
                }
            }
        }
    }
}
