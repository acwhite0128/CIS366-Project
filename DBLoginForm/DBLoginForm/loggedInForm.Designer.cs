namespace DBLoginForm
{
    partial class loggedInForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginSuccessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginSuccessLabel
            // 
            this.loginSuccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSuccessLabel.Location = new System.Drawing.Point(53, 158);
            this.loginSuccessLabel.Name = "loginSuccessLabel";
            this.loginSuccessLabel.Size = new System.Drawing.Size(688, 80);
            this.loginSuccessLabel.TabIndex = 0;
            this.loginSuccessLabel.Text = "You have logged in successfully!";
            this.loginSuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginSuccessLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "loggedInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logged In";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginSuccessLabel;
    }
}