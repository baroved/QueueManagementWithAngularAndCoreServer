using ApiAngular.Infra;
using ApiAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAngular.Service
{
    public class ServiceUser : IServiceUser
    {
        public List<User> UsersList { get; set; }
        public ServiceUser()
        {
            UsersList = new List<User>();
            
        }
        public List<User> AddUser(User newUser)
        {
            UsersList.Add(newUser);
              return UsersList;
        }

        public List<User> DeleteUser()
        {
            UsersList.RemoveAt(0);
            return UsersList;
        }

        public List<User> GetAllUsersInArray()
        {
            return UsersList;
        }

        
    }
}
