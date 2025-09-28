using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChimeraToolMobilePhoneDriversSetup.Pages
{
    public partial class Banner : Panel
    {
        public Banner()
        {
            InitializeComponent();

            //this.Location = new Point(0, -6);
            //subTextLbl.Location = new Point(0, 0);

            headerLbl.Location = new System.Drawing.Point(167, 20);
            subTextLbl.Location = new System.Drawing.Point(185, 42);

            logoPicture.Location = new System.Drawing.Point(logoPicture.Location.X, logoPicture.Location.Y + 6);
        }
    }
}
