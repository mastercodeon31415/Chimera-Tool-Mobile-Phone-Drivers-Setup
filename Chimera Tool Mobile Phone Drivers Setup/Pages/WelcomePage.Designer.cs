namespace ChimeraToolMobilePhoneDriversSetup.Pages
{
    partial class WelcomePage
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            logoBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(240, 22);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.MaximumSize = new Size(350, 0);
            label5.Name = "label5";
            label5.Size = new Size(341, 48);
            label5.TabIndex = 5;
            label5.Text = "Welcome to the Chimera Tool Mobile Phone Drivers Setup Wizard";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(241, 133);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.MaximumSize = new Size(350, 0);
            label4.Name = "label4";
            label4.Size = new Size(321, 26);
            label4.TabIndex = 4;
            label4.Text = "This installer was designed to automate the process of installing all mobile phone drivers that have been leaked from Chimera Tool.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(241, 239);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.MaximumSize = new Size(350, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 13);
            label3.TabIndex = 3;
            label3.Text = "Click Next to continue.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(241, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.MaximumSize = new Size(350, 0);
            label2.Name = "label2";
            label2.Size = new Size(334, 26);
            label2.TabIndex = 2;
            label2.Text = "It is recommended that you close all other applications before starting Setup. ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(241, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.MaximumSize = new Size(350, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 26);
            label1.TabIndex = 1;
            label1.Text = "This wizard will guide you through the installation process of Chimera Mobile Phone Drivers";
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.FromArgb(33, 33, 33);
            logoBox.Image = Properties.Resources.welcomeBanner4;
            logoBox.Location = new Point(0, 0);
            logoBox.Margin = new Padding(4, 3, 4, 3);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(233, 373);
            logoBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logoBox);
            Location = new Point(0, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "WelcomePage";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
