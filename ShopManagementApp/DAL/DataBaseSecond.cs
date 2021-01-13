using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApp.DAL
{
    public static class DataBaseSecond
    {
        static DataBaseSecond()
        {
            Users = Users ?? new EntityModel<User>();
            Books = Books ?? new EntityModel<Book>();
        }
        public static EntityModel<User> Users { get; set; }
        public static EntityModel<Book> Books { get; set; }

    }
}
