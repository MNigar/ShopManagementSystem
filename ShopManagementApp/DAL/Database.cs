using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApp.DAL
{
  public   class Database
    {
        private static List<User> _Users;

        public Database()
        {
            _Users = new List<User>();
        }
        public  void Adduser(User user)
        {
            _Users.Add(user);

        }
        public static void RemoveUser(User user)
        {
            _Users.Remove(user);

        }
        public static List<User> GetAll()
        {
            return _Users;

        }

    }
}
