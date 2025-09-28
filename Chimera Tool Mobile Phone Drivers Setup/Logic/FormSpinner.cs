using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChimeraToolMobilePhoneDriversSetup.Logic
{
    public class FormSpinner
    {
        public TimeSpan Duration { get; set; } = TimeSpan.FromMilliseconds(80);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetWindowText(IntPtr hWnd, string lpString);

        /*
		 * https://github.com/sindresorhus/cli-spinners/blob/main/spinners.json
		 *
		 * https://jsbin.com/tofehujixe/1/edit?js,output
		 * https://www.npmjs.com/package/cli-spinners
		 * https://www.fileformat.info/info/unicode/block/braille_patterns/images.htm
		 */

        #region Spinners

        public static string[] Wheel =
        {
            "🕛", "🕧", "🕐", "🕜", "🕑", "🕝", "🕒", "🕞", "🕓", "🕟", "🕔", "🕠",
            "🕕", "🕡", "🕖", "🕢", "🕗", "🕣", "🕘", "🕤", "🕙", "🕥", "🕚", "🕦"
        };

        public static string[] Dots =
        {
            "⠋",
            "⠙",
            "⠹",
            "⠸",
            "⠼",
            "⠴",
            "⠦",
            "⠧",
            "⠇",
            "⠏"
        };

        public static string[] Dots2 =
        {
            "⣾",
            "⣽",
            "⣻",
            "⢿",
            "⡿",
            "⣟",
            "⣯",
            "⣷"
        };

        public static string[] Dots3 =
        {
            "⠋",
            "⠙",
            "⠚",
            "⠞",
            "⠖",
            "⠦",
            "⠴",
            "⠲",
            "⠳",
            "⠓"
        };

        public static string[] Dots4 =
        {
            "⠄",
            "⠆",
            "⠇",
            "⠋",
            "⠙",
            "⠸",
            "⠰",
            "⠠",
            "⠰",
            "⠸",
            "⠙",
            "⠋",
            "⠇",
            "⠆"
        };

        public static string[] Dots5 =
        {
            "⠋",
            "⠙",
            "⠚",
            "⠒",
            "⠂",
            "⠂",
            "⠒",
            "⠲",
            "⠴",
            "⠦",
            "⠖",
            "⠒",
            "⠐",
            "⠐",
            "⠒",
            "⠓",
            "⠋"
        };

        public static string[] Dots8Bit =
        {
            "⠀",
            "⠁",
            "⠂",
            "⠃",
            "⠄",
            "⠅",
            "⠆",
            "⠇",
            "⡀",
            "⡁",
            "⡂",
            "⡃",
            "⡄",
            "⡅",
            "⡆",
            "⡇",
            "⠈",
            "⠉",
            "⠊",
            "⠋",
            "⠌",
            "⠍",
            "⠎",
            "⠏",
            "⡈",
            "⡉",
            "⡊",
            "⡋",
            "⡌",
            "⡍",
            "⡎",
            "⡏",
            "⠐",
            "⠑",
            "⠒",
            "⠓",
            "⠔",
            "⠕",
            "⠖",
            "⠗",
            "⡐",
            "⡑",
            "⡒",
            "⡓",
            "⡔",
            "⡕",
            "⡖",
            "⡗",
            "⠘",
            "⠙",
            "⠚",
            "⠛",
            "⠜",
            "⠝",
            "⠞",
            "⠟",
            "⡘",
            "⡙",
            "⡚",
            "⡛",
            "⡜",
            "⡝",
            "⡞",
            "⡟",
            "⠠",
            "⠡",
            "⠢",
            "⠣",
            "⠤",
            "⠥",
            "⠦",
            "⠧",
            "⡠",
            "⡡",
            "⡢",
            "⡣",
            "⡤",
            "⡥",
            "⡦",
            "⡧",
            "⠨",
            "⠩",
            "⠪",
            "⠫",
            "⠬",
            "⠭",
            "⠮",
            "⠯",
            "⡨",
            "⡩",
            "⡪",
            "⡫",
            "⡬",
            "⡭",
            "⡮",
            "⡯",
            "⠰",
            "⠱",
            "⠲",
            "⠳",
            "⠴",
            "⠵",
            "⠶",
            "⠷",
            "⡰",
            "⡱",
            "⡲",
            "⡳",
            "⡴",
            "⡵",
            "⡶",
            "⡷",
            "⠸",
            "⠹",
            "⠺",
            "⠻",
            "⠼",
            "⠽",
            "⠾",
            "⠿",
            "⡸",
            "⡹",
            "⡺",
            "⡻",
            "⡼",
            "⡽",
            "⡾",
            "⡿",
            "⢀",
            "⢁",
            "⢂",
            "⢃",
            "⢄",
            "⢅",
            "⢆",
            "⢇",
            "⣀",
            "⣁",
            "⣂",
            "⣃",
            "⣄",
            "⣅",
            "⣆",
            "⣇",
            "⢈",
            "⢉",
            "⢊",
            "⢋",
            "⢌",
            "⢍",
            "⢎",
            "⢏",
            "⣈",
            "⣉",
            "⣊",
            "⣋",
            "⣌",
            "⣍",
            "⣎",
            "⣏",
            "⢐",
            "⢑",
            "⢒",
            "⢓",
            "⢔",
            "⢕",
            "⢖",
            "⢗",
            "⣐",
            "⣑",
            "⣒",
            "⣓",
            "⣔",
            "⣕",
            "⣖",
            "⣗",
            "⢘",
            "⢙",
            "⢚",
            "⢛",
            "⢜",
            "⢝",
            "⢞",
            "⢟",
            "⣘",
            "⣙",
            "⣚",
            "⣛",
            "⣜",
            "⣝",
            "⣞",
            "⣟",
            "⢠",
            "⢡",
            "⢢",
            "⢣",
            "⢤",
            "⢥",
            "⢦",
            "⢧",
            "⣠",
            "⣡",
            "⣢",
            "⣣",
            "⣤",
            "⣥",
            "⣦",
            "⣧",
            "⢨",
            "⢩",
            "⢪",
            "⢫",
            "⢬",
            "⢭",
            "⢮",
            "⢯",
            "⣨",
            "⣩",
            "⣪",
            "⣫",
            "⣬",
            "⣭",
            "⣮",
            "⣯",
            "⢰",
            "⢱",
            "⢲",
            "⢳",
            "⢴",
            "⢵",
            "⢶",
            "⢷",
            "⣰",
            "⣱",
            "⣲",
            "⣳",
            "⣴",
            "⣵",
            "⣶",
            "⣷",
            "⢸",
            "⢹",
            "⢺",
            "⢻",
            "⢼",
            "⢽",
            "⢾",
            "⢿",
            "⣸",
            "⣹",
            "⣺",
            "⣻",
            "⣼",
            "⣽",
            "⣾",
            "⣿"
        };

        public static string[] Dots9 =
        {
            "⢹",
            "⢺",
            "⢼",
            "⣸",
            "⣇",
            "⡧",
            "⡗",
            "⡏"
        };

        public static string[] Dots10 =
        {
            "⢄",
            "⢂",
            "⢁",
            "⡁",
            "⡈",
            "⡐",
            "⡠"
        };

        public static string[] Dots11 =
        {
            "⠁",
            "⠂",
            "⠄",
            "⡀",
            "⢀",
            "⠠",
            "⠐",
            "⠈"
        };

        public static string[] Dots12 =
        {
            "⢀⠀",
            "⡀⠀",
            "⠄⠀",
            "⢂⠀",
            "⡂⠀",
            "⠅⠀",
            "⢃⠀",
            "⡃⠀",
            "⠍⠀",
            "⢋⠀",
            "⡋⠀",
            "⠍⠁",
            "⢋⠁",
            "⡋⠁",
            "⠍⠉",
            "⠋⠉",
            "⠋⠉",
            "⠉⠙",
            "⠉⠙",
            "⠉⠩",
            "⠈⢙",
            "⠈⡙",
            "⢈⠩",
            "⡀⢙",
            "⠄⡙",
            "⢂⠩",
            "⡂⢘",
            "⠅⡘",
            "⢃⠨",
            "⡃⢐",
            "⠍⡐",
            "⢋⠠",
            "⡋⢀",
            "⠍⡁",
            "⢋⠁",
            "⡋⠁",
            "⠍⠉",
            "⠋⠉",
            "⠋⠉",
            "⠉⠙",
            "⠉⠙",
            "⠉⠩",
            "⠈⢙",
            "⠈⡙",
            "⠈⠩",
            "⠀⢙",
            "⠀⡙",
            "⠀⠩",
            "⠀⢘",
            "⠀⡘",
            "⠀⠨",
            "⠀⢐",
            "⠀⡐",
            "⠀⠠",
            "⠀⢀",
            "⠀⡀"
        };

        public static string[] Progress7 =
        {
            "▰▱▱▱▱▱▱",
            "▰▰▱▱▱▱▱",
            "▰▰▰▱▱▱▱",
            "▰▰▰▰▱▱▱",
            "▰▰▰▰▰▱▱",
            "▰▰▰▰▰▰▱",
            "▰▰▰▰▰▰▰",
            "▰▱▱▱▱▱▱"
        };

        public static string[] Progress10 =
        {
            "▰▱▱▱▱▱▱▱▱▱",
            "▰▰▱▱▱▱▱▱▱▱",
            "▰▰▰▱▱▱▱▱▱▱",
            "▰▰▰▰▱▱▱▱▱▱",
            "▰▰▰▰▰▱▱▱▱▱",
            "▰▰▰▰▰▰▱▱▱▱",
            "▰▰▰▰▰▰▰▱▱▱",
            "▰▰▰▰▰▰▰▰▱▱",
            "▰▰▰▰▰▰▰▰▰▱",
            "▰▰▰▰▰▰▰▰▰▰",
            "▰▱▱▱▱▱▱▱▱▱"
        };

        public static string[] Line =
        {
            "-",
            "\\",
            "|",
            "/"
        };

        #endregion

        public Form frmWindow { get; set; }

        public bool InvokeRequired
        {
            get
            {
                if (frmWindow != null) return frmWindow.InvokeRequired;
                else return false;
            }
        }

        public FormSpinner(Form frm)
        {
            this.frmWindow = frm;
            this.formOldText = this.frmWindow.Text;
        }

        private delegate void setFormTextDelegate(string text);
        private void setFormText(string text)
        {
            if (this.frmWindow.InvokeRequired)
            {
                var d = new setFormTextDelegate(setFormText);
                try
                {
                    this.frmWindow.Invoke(d, new object[] { text });
                }
                catch { }
            }
            else
            {
                this.frmWindow.Text = text;
                //SetWindowText(this.frmWindow.Handle, text);
                Application.DoEvents();
            }
        }

        private CancellationTokenSource _cancelToken;
        public bool IsRunning = false;

        private string formOldText = String.Empty;

        public void Start()
        {
            formOldText = this.frmWindow.Text;
            this.frmWindow.ShowIcon = false;
            _cancelToken = new CancellationTokenSource();
            this.IsRunning = true;
            Queue(_cancelToken);
        }

        public void Stop()
        {
            if (_cancelToken != null && this.IsRunning == true)
            {
                this.IsRunning = false;
                _cancelToken.Cancel();

                this.frmWindow.ShowIcon = true;
                setFormText(formOldText);
            }
        }

        public void Reset()
        {
            if (_cancelToken != null && this.IsRunning == true)
            {
                this.Stop();

                this.Start();
            }
        }


        public string[] Current { get; set; } = Dots2;

        

        private void ForTask(Task t)
        {
            var cts = new CancellationTokenSource();
            Queue(cts);
            // ReSharper disable once MethodSupportsCancellation
            t.Wait();
            cts.Cancel();
            cts.Dispose();
        }

        private void Queue(CancellationTokenSource cts)
        {
            // Pass the token to the cancelable operation.
            ThreadPool.QueueUserWorkItem(Show, cts.Token);
        }

        private void Show(object obj)
        {
            var token = (CancellationToken)obj;

            while (!token.IsCancellationRequested)
            {
                foreach (string t in Current)
                {
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }

                    this.setFormText($"{t} {this.formOldText} ");

                    Thread.Sleep(Duration);
                }
            }

            setFormText(this.formOldText);
        }
    }
}