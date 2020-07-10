using ApiAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAngular.Infra
{
    public interface IServiceUser
    {
        List<User> GetAllUsersInArray();
        List<User> AddUser(User newUser);
        List<User> DeleteUser();
    }
}
