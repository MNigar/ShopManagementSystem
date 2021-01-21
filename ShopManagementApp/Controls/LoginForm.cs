using ShopManagementApp.Controls;
using ShopManagementApp.DAL;
using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

      
        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userList = DataBaseSecond.Users.GetAll();
            string email = txb_Email.Text;
            string password = txb_Password.Text;
            var result = DataBaseSecond.Users.IfExist(email,password, userList);
            //if(!string.IsNullOrEmpty(txb_Email.Text) && !string.IsNullOrEmpty(txb_Password.Text)                
            //    && userList.Any(user=> user.Email.ToLower()==txb_Email.Text.ToLower() && user.Password == txb_Password.Text))
            if ( result)
            {
                BookForm bookForm = new BookForm();
                bookForm.ShowDialog();
            }
              else  
            {
                MessageBox.Show("Email və ya şifrə doğru daxil edilməyib");
            }
            
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {

            RegistrationForm registration = new RegistrationForm(this);

           registration.ShowDialog();
        }

        private void gbx_Login_Enter(object sender, EventArgs e)
        {

        }
    }
}
