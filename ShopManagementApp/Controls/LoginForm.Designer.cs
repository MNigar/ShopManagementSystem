
namespace ShopManagementApp
{
    partial class LoginForm
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
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.gbx_Login = new System.Windows.Forms.GroupBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.gbx_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(98, 39);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(108, 20);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Elektron Poçt ";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(98, 107);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(42, 20);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Şifrə";
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(102, 62);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(250, 26);
            this.txb_Email.TabIndex = 2;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(102, 130);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(250, 26);
            this.txb_Password.TabIndex = 3;
            this.txb_Password.UseSystemPasswordChar = true;
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(135, 243);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(193, 34);
            this.btn_Registration.TabIndex = 5;
            this.btn_Registration.Text = "Qeydiyyatdan Keç";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // gbx_Login
            // 
            this.gbx_Login.Controls.Add(this.btn_Login);
            this.gbx_Login.Controls.Add(this.txb_Password);
            this.gbx_Login.Controls.Add(this.btn_Registration);
            this.gbx_Login.Controls.Add(this.lbl_Email);
            this.gbx_Login.Controls.Add(this.lbl_Password);
            this.gbx_Login.Controls.Add(this.txb_Email);
            this.gbx_Login.Location = new System.Drawing.Point(170, 39);
            this.gbx_Login.Name = "gbx_Login";
            this.gbx_Login.Size = new System.Drawing.Size(449, 377);
            this.gbx_Login.TabIndex = 6;
            this.gbx_Login.TabStop = false;
            this.gbx_Login.Text = "Login";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(169, 171);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(111, 34);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Daxil ol";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_Login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.gbx_Login.ResumeLayout(false);
            this.gbx_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.GroupBox gbx_Login;
        private System.Windows.Forms.Button btn_Login;
    }
}

