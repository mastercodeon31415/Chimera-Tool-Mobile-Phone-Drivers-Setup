using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WSA_Installer.Logic;

namespace ChimeraToolMobilePhoneDriversSetup.Pages
{
    public partial class Page : UserControl
    {
        public bool NoBanner = false;
        public Page()
        {
            InitializeComponent();

            this.Size = new Size(631, 392);
            this.Location = new Point(12, 80);
        }

        public Banner parentBanner = null;
        public Page(Banner prntBanner)
        {
            InitializeComponent();

            parentBanner = prntBanner;

            this.Size = new Size(631, 392);
            this.Location = new Point(12, 80);
            parentBanner.Location = Point.Empty;
        }

        public virtual void ChangeBannerText()
        {

        }
    }
}
