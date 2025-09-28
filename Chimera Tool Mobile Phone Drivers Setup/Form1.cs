using ChimeraToolMobilePhoneDriversSetup.Logic;
using System.Diagnostics;
using System.IO.Compression;
using System.Reflection;
using ChimeraToolMobilePhoneDriversSetup.Pages;

namespace ChimeraToolMobilePhoneDriversSetup
{
    public partial class Form1 : Form
    {
        private int pageIdx = 0;
        public Control[] pages = null;
        private Control currentPage = null;
        private Banner bannerBox = null;
        public FormSpinner frmSpinner;
        public static Form1 Instance;
        private Installer installer;

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            frmSpinner = new FormSpinner(this);
            frmSpinner.Current = FormSpinner.Wheel;
            bannerBox = new Banner();
            bannerBox.Visible = true;
            pages = new Control[]
            {
                new WelcomePage(),
                new InstallingPage(bannerBox),
                new SetupFinishedPage()

            };
            installer = new Installer();
            installer.InstallationFinished += Installer_InstallationFinished;
            updatePage();
        }

        private async void Installer_InstallationFinished(object sender, EventArgs e)
        {
            if (this.pageIdx + 1 < pages.Length)
            {
                cancelBtn.Enabled = false;
                this.nextBtn.Enabled = true;
                this.backBtn.Visible = false;
                this.backBtn.Text = "Reboot Now";
                this.backBtn.Enabled = true;
                this.backBtn.Location = new Point(this.cancelBtn.Location.X, this.cancelBtn.Location.Y);
                this.ControlBox = true;
                lineLbl.Visible = true;
            }
        }

        private async Task updatePage()
        {
            if (this.currentPage != null)
            {
                this.Controls.Remove(this.currentPage);
            }

            this.currentPage = pages[this.pageIdx];
            this.Controls.Add(pages[this.pageIdx]);
            Page pg = (Page)this.currentPage;
            pg.ChangeBannerText();

            switch (this.currentPage.Tag)
            {
                case "WelcomePage":
                    {
                        this.backBtn.Visible = false;
                        this.nextBtn.Text = "Next >";
                        if (this.Controls.Contains(bannerBox)) this.Controls.Remove(bannerBox);
                        this.ControlBox = true;
                        break;
                    }

                case "SetupFinishedPage":
                    {
                        cancelBtn.Visible = false;

                        this.nextBtn.Text = "Finish";
                        this.backBtn.Visible = true;
                        lineLbl.Visible = true;
                        if (this.Controls.Contains(bannerBox))
                        {
                            this.Controls.Remove(bannerBox);
                        }

                        this.currentPage.Location = new Point(12, 12);
                        break;
                    }

                case "InstallerPage":
                    {
                        this.nextBtn.Text = "Next >";
                        this.nextBtn.Enabled = false;
                        this.backBtn.Enabled = false;
                        frmSpinner.Start();

                        if (((Page)currentPage).NoBanner == true)
                        {
                            if (this.Controls.Contains(bannerBox))
                            {
                                this.Controls.Remove(bannerBox);
                            }
                            this.currentPage.Location = new Point(0, 0);
                            this.currentPage.Size = new Size(541, 244);

                        }
                        else
                        {
                            this.lineLbl.Visible = true;
                            this.backBtn.Visible = true;
                            this.currentPage.Location = new Point(12, 80);
                            if (!this.Controls.Contains(bannerBox)) this.Controls.Add(bannerBox);
                        }

                        await installer.Install();

                        break;
                    }
            }

            if (((Page)currentPage).NoBanner == true)
            {
                if (this.Controls.Contains(bannerBox))
                {
                    this.Controls.Remove(bannerBox);
                }
                this.currentPage.Location = new Point(0, 0);
                this.currentPage.Size = new Size(631, 392);

            }
            else
            {
                this.lineLbl.Visible = true;
                this.currentPage.Location = new Point(12, 80);
                if (!this.Controls.Contains(bannerBox)) this.Controls.Add(bannerBox);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage.Tag == (object)"InstallerPage")
            {
                pageIdx = pages.Length - 1;
                bannerBox.Visible = false;
                await updatePage();
                return;
            }

            if (nextBtn.Text == "Finish")
            {
                this.Close();
            }

            if (this.pageIdx + 1 < pages.Length)
            {
                this.pageIdx += 1;
            }

            await updatePage();
        }

        private async void backBtn_Click(object sender, EventArgs e)
        {
            if (this.backBtn.Text == "Reboot Now")
            {
                Process.Start("shutdown", "/r /t 0");
            }
            else
            {
                if (this.pageIdx - 1 >= 0)
                {
                    this.pageIdx -= 1;
                }

                await updatePage();
            }
        }
    }
}
