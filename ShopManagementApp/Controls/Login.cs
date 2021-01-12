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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gbx_Login_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userList = DAL.Database.GetAll();
            if(!string.IsNullOrEmpty(txb_Email.Text) && !string.IsNullOrEmpty(txb_Password.Text)                
                && userList.Any(user=> user.Email==txb_Email.Text && user.Password == txb_Password.Text))
            {
                MessageBox.Show("Daxil oldunuz");
            }
              else  
            {
                MessageBox.Show("Email və ya şifrə doğru daxil edilməyib");
            }
            
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {

            Registration registration = new Registration();

           registration.Show();
        }
    }
}
