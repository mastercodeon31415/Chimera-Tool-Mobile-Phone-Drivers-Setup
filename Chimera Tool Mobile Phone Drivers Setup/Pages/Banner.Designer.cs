namespace ChimeraToolMobilePhoneDriversSetup.Pages
{
    partial class Banner
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            subTextLbl = new Label();
            headerLbl = new Label();
            logoPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoPicture).BeginInit();
            SuspendLayout();
            // 
            // subTextLbl
            // 
            subTextLbl.BackColor = Color.FromArgb(33, 33, 33);
            subTextLbl.Font = new Font("Microsoft Sans Serif", 8.25F);
            subTextLbl.ForeColor = Color.Silver;
            subTextLbl.Name = "subTextLbl";
            subTextLbl.Size = new Size(349, 13);
            subTextLbl.TabIndex = 12;
            subTextLbl.Text = "Choose the folder in which to install Chimera Mobile Phone Drivers Setup";
            // 
            // headerLbl
            // 
            headerLbl.AutoSize = true;
            headerLbl.BackColor = Color.FromArgb(33, 33, 33);
            headerLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLbl.ForeColor = Color.Silver;
            headerLbl.Margin = new Padding(2, 0, 2, 0);
            headerLbl.Name = "headerLbl";
            headerLbl.Size = new Size(157, 15);
            headerLbl.TabIndex = 11;
            headerLbl.Text = "Choose Install Location";
            // 
            // logoPicture
            // 
            logoPicture.BackColor = Color.FromArgb(33, 33, 33);
            logoPicture.ForeColor = Color.Silver;
            logoPicture.Image = ChimeraToolMobilePhoneDriversSetup.Properties.Resources.banner3;
            logoPicture.Name = "logoPicture";
            logoPicture.Size = new Size(162, 72);
            logoPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPicture.TabIndex = 13;
            logoPicture.TabStop = false;
            // 
            // Banner
            // 
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(logoPicture);
            Controls.Add(subTextLbl);
            Controls.Add(headerLbl);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = Color.Silver;
            Size = new Size(575, 81);
            ((System.ComponentModel.ISupportInitialize)logoPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox logoPicture;
        public System.Windows.Forms.Label subTextLbl;
        public System.Windows.Forms.Label headerLbl;
    }
}
