using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ChimeraToolMobilePhoneDriversSetup.Pages
{
	public partial class InstallingPage : Page
    {
		public string InstallLocation = "";

        public InstallingPage(Banner prntBanner) : base(prntBanner)
        {
            InitializeComponent();
            this.Tag = "InstallerPage";
            this.NoBanner = false;

            //this.progressBar1.Value = 0;
		}

		private void showDetailsBtn_Click(object sender, EventArgs e)
        {
            this.showDetailsBtn.Visible = false;
            this.detailsBox.Visible = true;
        }

        public void AddDetail(string detail)
        {
            detailsBox.Items.Add(detail);
            detailsBox.SelectedIndex = detailsBox.Items.Count - 1;
        }

        public override void ChangeBannerText()
        {
            parentBanner.headerLbl.Text = "Installing";
            parentBanner.subTextLbl.Text = "Please wait while Chimera Mobile Phone Drivers is being installed.";
        }

        public void FinishedBannerText()
        {
            parentBanner.headerLbl.Text = "Installation Complete";
            parentBanner.subTextLbl.Text = "Installation was completed successfully.";
        }
    }
}
