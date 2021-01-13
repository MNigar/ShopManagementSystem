﻿using ShopManagementApp.DAL;
using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.registrationControl1.btn_Registration.Click += Btn_Registration_Click;
            this.registrationControl1.btn_login.Click += Btn_login_Click;           
        }
        private Form _loginForm;
        public RegistrationForm(Form form):this()
        {
            _loginForm = form;
        }
        private void Btn_login_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();          
            login.Show();           
        }

        private void Btn_Registration_Click(object sender, EventArgs e)
        {
            string email = this.registrationControl1.txb_Email.Text;

            var userList = DataBaseSecond.Users.GetAll();
            
            
            if (!string.IsNullOrEmpty(this.registrationControl1.txb_Email.Text)
                && Regex.IsMatch(this.registrationControl1.txb_Email.Text, @"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$")
                && !string.IsNullOrEmpty(this.registrationControl1.txb_Name.Text)
                && !string.IsNullOrEmpty(this.registrationControl1.txb_Surname.Text)
                && !string.IsNullOrEmpty(this.registrationControl1.txb_Password.Text) && this.registrationControl1.txb_Password.Text.Length > 6)
            {
                var result = DataBaseSecond.Users.IfAlreadyExist(email, userList);
                if(result)
                {
                    MessageBox.Show("Bu istifadəçi artıq mövcuddur");
                }
                else
                {
                    User newUser = new User()
                    {
                        Name = this.registrationControl1.txb_Name.Text,
                        Surname = this.registrationControl1.txb_Surname.Text,
                        Email = this.registrationControl1.txb_Email.Text,
                        Password = this.registrationControl1.txb_Password.Text
                    };
                    DataBaseSecond.Users.Add(newUser);
                    //Database database = new Database();
                    //database.Adduser(newUser);
                    //MessageBox.Show("Ugurlu");
                }
            
            }
            else
            {
                MessageBox.Show("Yalnish");
            }
            _loginForm.Show();
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = "Nigar",
                Surname = "Mammadova",
                Email = "nigar@gmail.com",
                Password = "nigar"
            };
            DataBaseSecond.Users.Add(user);

        }

      
    }
}
