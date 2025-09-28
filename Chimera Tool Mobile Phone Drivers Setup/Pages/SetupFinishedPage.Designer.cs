namespace ChimeraToolMobilePhoneDriversSetup.Pages
{
    partial class SetupFinishedPage
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(240, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.MaximumSize = new Size(350, 0);
            label5.Name = "label5";
            label5.Size = new Size(342, 48);
            label5.TabIndex = 11;
            label5.Text = "Completing Chimera Mobile Phone Drivers Setup";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.MaximumSize = new Size(350, 0);
            label4.Name = "label4";
            label4.Size = new Size(304, 15);
            label4.TabIndex = 10;
            label4.Text = "A restart is required since we had to install all the drivers.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.MaximumSize = new Size(350, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 30);
            label1.TabIndex = 7;
            label1.Text = "Chimera Mobile Phone Drivers has been installed on your computer.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(33, 33, 33);
            pictureBox1.Image = ChimeraToolMobilePhoneDriversSetup.Properties.Resources.welcomeBanner4;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 201);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.MaximumSize = new Size(350, 0);
            label2.Name = "label2";
            label2.Size = new Size(347, 45);
            label2.TabIndex = 14;
            label2.Text = "Click Finish to close Setup and reboot later, or click Reboot Now to close the setup and reboot right away. Please make sure everything that you have open is saved to avoid data loss. ";
            // 
            // SetupFinishedPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Location = new Point(0, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "SetupFinishedPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
