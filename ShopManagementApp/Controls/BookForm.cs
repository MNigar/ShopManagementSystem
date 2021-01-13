using ShopManagementApp.DAL;
using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementApp.Controls
{
    public partial class BookForm : Form
    {
       
        private Form _LoginForm;
        public BookForm(Form form)
        {
            _LoginForm = form;
            InitializeComponent();
            Book book1 = new Book()
            {
                Id = 1,
                Name = "C#",
                Image = @"D:\C#course\ShopManagementApp\ShopManagementApp\Images\4136Vv9FsvL._SX334_BO1,204,203,200_.jpg"
            };
            Book book2 = new Book()
            {
                Id = 1,
                Name = "Java",
                Image= @"D:\C#course\ShopManagementApp\ShopManagementApp\Images\51tjBN6kkEL._SX374_BO1,204,203,200_.jpg"
            };
            Book book3 = new Book()
            {
                Id = 1,
                Name = "Python",
                Image = @"D:\C#course\ShopManagementApp\ShopManagementApp\Images\images.jpg"
            };
            DataBaseSecond.Books.Add(book1);
            DataBaseSecond.Books.Add(book2);
            DataBaseSecond.Books.Add(book3);
            var bookList = DataBaseSecond.Books.GetAll();
            int x = 75;
            int picX = 280;
            foreach ( var book in bookList)
            { 
                GroupBox groupBox = new GroupBox();
                groupBox.Text = book.Name;
                groupBox.Size = new Size(200, 200);
                groupBox.Location = new Point(x,23);
                x +=310;  
                this.Controls.Add(groupBox);
                #region add book image first method
                //PictureBox picture = new PictureBox();
                //picture.Name = "pictureBox";
                //picture.Size = new Size(100, 100);
                //picture.Location = new Point(picX, 23);
                //picture.SizeMode = PictureBoxSizeMode.StretchImage;
                //picture.Image = Image.FromFile(book.Image);

                //picX += 310;
                //this.Controls.Add(picture);
                #endregion
            }

            #region add book image Second method

            string[] images = Directory.GetFiles(@"D:\C#course\ShopManagementApp\ShopManagementApp\Images", "*.jpg");
            foreach (var image in images)
            {

                PictureBox pictureBox = new PictureBox();

                pictureBox.Name = "pictureBox";
                pictureBox.Size = new Size(100, 100);
                pictureBox.Location = new Point(picX, 23);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(image);

                picX += 310;
                this.Controls.Add(pictureBox);


            }
            #endregion
        }

        public BookForm() : this(null) { }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
