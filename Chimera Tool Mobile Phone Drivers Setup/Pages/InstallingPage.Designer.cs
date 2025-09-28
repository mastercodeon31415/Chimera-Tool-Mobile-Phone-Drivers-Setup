namespace ChimeraToolMobilePhoneDriversSetup.Pages
{
    partial class InstallingPage
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
            showDetailsBtn = new Button();
            statusLbl = new Label();
            progressBar1 = new ProgressBar();
            detailsBox = new ListBox();
            SuspendLayout();
            // 
            // showDetailsBtn
            // 
            showDetailsBtn.FlatStyle = FlatStyle.System;
            showDetailsBtn.Location = new Point(450, 46);
            showDetailsBtn.Name = "showDetailsBtn";
            showDetailsBtn.Size = new Size(88, 23);
            showDetailsBtn.TabIndex = 2;
            showDetailsBtn.Text = "Show details";
            showDetailsBtn.UseVisualStyleBackColor = true;
            showDetailsBtn.Visible = false;
            showDetailsBtn.Click += showDetailsBtn_Click;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Font = new Font("Microsoft Sans Serif", 8.25F);
            statusLbl.ForeColor = Color.Silver;
            statusLbl.Location = new Point(3, 1);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(57, 13);
            statusLbl.TabIndex = 1;
            statusLbl.Text = "Installing...";
            // 
            // progressBar1
            // 
            progressBar1.Enabled = false;
            progressBar1.Location = new Point(3, 17);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(535, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 0;
            progressBar1.Value = 25;
            // 
            // detailsBox
            // 
            detailsBox.BackColor = Color.FromArgb(33, 33, 33);
            detailsBox.BorderStyle = BorderStyle.FixedSingle;
            detailsBox.ForeColor = Color.Silver;
            detailsBox.FormattingEnabled = true;
            detailsBox.Location = new Point(3, 46);
            detailsBox.Name = "detailsBox";
            detailsBox.Size = new Size(535, 197);
            detailsBox.TabIndex = 3;
            // 
            // InstallingPage
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(showDetailsBtn);
            Controls.Add(statusLbl);
            Controls.Add(progressBar1);
            Controls.Add(detailsBox);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Location = new Point(0, 0);
            Name = "InstallingPage";
            Size = new Size(541, 244);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showDetailsBtn;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.ListBox detailsBox;
        public System.Windows.Forms.Label statusLbl;
    }
}
