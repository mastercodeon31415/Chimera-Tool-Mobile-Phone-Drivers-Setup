namespace ChimeraToolMobilePhoneDriversSetup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lineLbl = new Label();
            cancelBtn = new Button();
            nextBtn = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // lineLbl
            // 
            lineLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lineLbl.AutoSize = true;
            lineLbl.Font = new Font("Microsoft Sans Serif", 8.25F);
            lineLbl.Location = new Point(10, 357);
            lineLbl.Margin = new Padding(4, 0, 4, 0);
            lineLbl.Name = "lineLbl";
            lineLbl.Size = new Size(622, 17);
            lineLbl.TabIndex = 1;
            lineLbl.Text = "─────────────────────────────────────────────────────────────────────────────";
            lineLbl.UseCompatibleTextRendering = true;
            lineLbl.UseMnemonic = false;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Location = new Point(542, 386);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextBtn.Location = new Point(445, 386);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 23);
            nextBtn.TabIndex = 3;
            nextBtn.Text = "Next >";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backBtn.Location = new Point(364, 386);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 4;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 421);
            Controls.Add(backBtn);
            Controls.Add(nextBtn);
            Controls.Add(cancelBtn);
            Controls.Add(lineLbl);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Chimera Tool Mobile Phone Drivers Setup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lineLbl;
        private Button cancelBtn;
        private Button nextBtn;
        private Button backBtn;
    }
}
