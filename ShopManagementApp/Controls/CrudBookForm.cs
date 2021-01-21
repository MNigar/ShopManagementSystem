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
        public void GetAll()
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                var books = dataBase.GetAll();
                dgw_Books.DataSource = books;
            }
        }
        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                var books = dataBase.GetAll();
                //rtb_Table.Text = "";
                //foreach (var book in books)
                //{
                //    rtb_Table.Text += $"ID: {book.Id}  Name:{book.Name}  Price:{book.Price}" + Environment.NewLine;
                //}
                dgw_Books.DataSource = books;
            }

        }

        private void btn_GetById_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {

                int id = Convert.ToInt32(txb_Id.Text);
                var book = dataBase.GetById(id);
                //rtb_Table.Text = "";
                //rtb_Table.Text = $"ID: {book.Id}  Name:{book.Name}  Price:{book.Price}" + Environment.NewLine;

            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                if (!String.IsNullOrEmpty(txb_Name.Text) && !String.IsNullOrEmpty(txb_Price.Text))
                {
                    Book book = new Book();
                    book.Name = txb_Name.Text;
                    book.Price = Convert.ToDecimal(txb_Price.Text);
                    dataBase.Add(book);
                    GetAll();
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                if (!String.IsNullOrEmpty(txb_NameUpdate.Text) && !String.IsNullOrEmpty(txb_PriceUpdate.Text))
                {
                    //int id = Convert.ToInt32(txb_Id.Text);
                    //var book = dataBase.GetById(id);
                    Book book = new Book()
                    {
                        Id = Convert.ToInt32(dgw_Books.CurrentRow.Cells[2].Value),
                        Name = txb_NameUpdate.Text,
                        Price = Convert.ToDecimal(txb_PriceUpdate.Text),

                    };
                    dataBase.Update(book);
                    GetAll();
                }

            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (NewDataBase dataBase = new NewDataBase("Test"))
            {
                int id = Convert.ToInt32(dgw_Books.CurrentRow.Cells[2].Value);
                //rtb_Table.Text = "";
                //dataBase.Delete(id);
                //rtb_Table.Text = "Deleted";
                dataBase.Delete(id);

            }

        }

        private void dgw_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgw_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_CurrentId.Text = dgw_Books.CurrentRow.Cells[2].Value.ToString();
            txb_NameUpdate.Text = dgw_Books.CurrentRow.Cells[3].Value.ToString();
            txb_PriceUpdate.Text = dgw_Books.CurrentRow.Cells[1].Value.ToString();


        }
    }
}

        
    

