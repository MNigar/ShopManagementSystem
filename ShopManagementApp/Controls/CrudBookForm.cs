using ShopManagementApp.DAL;
using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementApp.Controls
{
    public partial class CrudBookForm : Form
    {
        public CrudBookForm()
        {
            InitializeComponent();
        }

        private void rtb_Table_TextChanged(object sender, EventArgs e)
        {

        }
        public void Show()
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                var books = dataBase.GetAll();
                foreach (var book in books)
                {
                    rtb_Table.Text += $"ID: {book.Id}  Name:{book.Name}  Price:{book.Price}" + Environment.NewLine;
                }
            }
        }
        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                var books = dataBase.GetAll();
                rtb_Table.Text = "";
                foreach (var book in books)
                {
                    rtb_Table.Text += $"ID: {book.Id}  Name:{book.Name}  Price:{book.Price}" + Environment.NewLine;
                }
            }

        }

        private void btn_GetById_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {

                int id = Convert.ToInt32(txb_Id.Text);
                var book = dataBase.GetById(id);
                rtb_Table.Text = "";
                rtb_Table.Text = $"ID: {book.Id}  Name:{book.Name}  Price:{book.Price}" + Environment.NewLine;

            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                
                Book book = new Book();                
                book.Name = txb_Name.Text;
                book.Price = Convert.ToDecimal(txb_Price.Text);
                dataBase.Insert(book);
                //rtb_Table.Text+= $"ID: {book.Id}  Name:{book.Name}  Price:{book.Price}" + Environment.NewLine;

                rtb_Table.Text = "";
                Show();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                int id = Convert.ToInt32(txb_Id.Text);
                var book = dataBase.GetById(id);              
                book.Name = txb_Name.Text;
                book.Price = Convert.ToDecimal(txb_Price.Text);
                dataBase.Update(id,book);
                rtb_Table.Text = "Updated";



            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                int id = Convert.ToInt32(txb_Id.Text);
                rtb_Table.Text = "";
                dataBase.Delete(id);
                rtb_Table.Text = "Deleted";


            }

        }
    }
}

        
    

