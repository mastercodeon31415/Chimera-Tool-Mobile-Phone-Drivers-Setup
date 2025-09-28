using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimeraToolMobilePhoneDriversSetup.Logic
{
	public class UpdateEventDels
	{
		public delegate void UpdateDetailsDel(string dets);
		public delegate void UpdateStatusDel(string dets);
		public delegate void UpdateProgDel(int prog);
	}
}
