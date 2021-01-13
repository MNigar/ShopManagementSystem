using ShopManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApp.DAL
{
   public class EntityModel<T> where T: Entity,new()
    {
        private  List<T> _Entities;
        public EntityModel()
        {
            if (_Entities == null)
            {
                _Entities = new List<T>();
            }
            
        }
        public void Add(T item)
        {
            _Entities.Add(item);

        }
        public  void Remove(T item)
        {
            _Entities.Remove(item);

        }
        public  List<T> GetAll()
        {
            return _Entities;

        }

        public bool IfExist(string email,string password, List<User> users)
        {
           bool result = false;
           if (users.Any(user=>user.Email.ToLower() == email.ToLower()
           && user.Password.ToLower()==password.ToLower()))
            {
                result = true;
            }        
            return result;
        }
        public bool IfAlreadyExist(string email, List<User> users)
        {
            bool result = false;
            if (users.Any(user => user.Email.ToLower() == email.ToLower()))
            
            {
                result = true;
            }
            return result;
        }

    }
}
