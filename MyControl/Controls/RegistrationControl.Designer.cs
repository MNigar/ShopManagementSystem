
namespace MyControl.Controls
{
    partial class RegistrationControl
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
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_Surname = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(194, 290);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(246, 26);
            this.txb_Password.TabIndex = 22;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(191, 215);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(249, 26);
            this.txb_Email.TabIndex = 21;
            // 
            // txb_Surname
            // 
            this.txb_Surname.Location = new System.Drawing.Point(191, 134);
            this.txb_Surname.Name = "txb_Surname";
            this.txb_Surname.Size = new System.Drawing.Size(249, 26);
            this.txb_Surname.TabIndex = 20;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(194, 56);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(246, 26);
            this.txb_Name.TabIndex = 19;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(190, 257);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(42, 20);
            this.lbl_Password.TabIndex = 18;
            this.lbl_Password.Text = "Şifrə";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(261, 405);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 37);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "Daxil ol";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(241, 335);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(157, 37);
            this.btn_Registration.TabIndex = 16;
            this.btn_Registration.Text = "Qeydiyyatdan keç";
            this.btn_Registration.UseVisualStyleBackColor = true;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(190, 180);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(104, 20);
            this.lbl_Email.TabIndex = 15;
            this.lbl_Email.Text = "Elektron Poçt";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(190, 95);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(54, 20);
            this.lbl_Surname.TabIndex = 14;
            this.lbl_Surname.Text = "Soyad";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(190, 19);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(29, 20);
            this.lbl_Name.TabIndex = 13;
            this.lbl_Name.Text = "Ad";
            // 
            // RegistrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.txb_Surname);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Name = "RegistrationControl";
            this.Size = new System.Drawing.Size(795, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txb_Password;
        public System.Windows.Forms.TextBox txb_Email;
        public System.Windows.Forms.TextBox txb_Surname;
        public System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lbl_Password;
        public System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_Name;
    }
}
