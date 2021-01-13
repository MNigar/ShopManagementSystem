
namespace ShopManagementApp
{
    partial class RegistrationForm
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
            this.registrationControl1 = new MyControl.Controls.RegistrationControl();
            this.SuspendLayout();
            // 
            // registrationControl1
            // 
            this.registrationControl1.Location = new System.Drawing.Point(28, 12);
            this.registrationControl1.Name = "registrationControl1";
            this.registrationControl1.Size = new System.Drawing.Size(795, 554);
            this.registrationControl1.TabIndex = 0;
            this.registrationControl1.Load += new System.EventHandler(this.registrationControl1_Load);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 560);
            this.Controls.Add(this.registrationControl1);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl.Controls.RegistrationControl registrationControl1;
    }
}