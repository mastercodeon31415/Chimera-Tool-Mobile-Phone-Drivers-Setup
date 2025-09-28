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
	public partial class SetupFinishedPage : Page
	{
		private bool _IsRestartNeeded = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsRestartNeeded
		{
			get
			{
				return _IsRestartNeeded;
			}
			set
			{
				_IsRestartNeeded = value;

				if (!_IsRestartNeeded)
				{
					label4.Visible = false;
					label2.Text = "You can now launch Chimera Mobile Phone Drivers Setup like normally and everything should work out of the box! Thank you for using my Chimera Mobile Phone Drivers installer. Click Finish to close Setup.";
					label2.Location = new Point(207, 95);
				}
			}
		}


		public SetupFinishedPage()
		{
			InitializeComponent();
			this.Tag = "SetupFinishedPage";
			this.NoBanner = true;
			this.Size = new Size(541, 330);
		}
	}
}
