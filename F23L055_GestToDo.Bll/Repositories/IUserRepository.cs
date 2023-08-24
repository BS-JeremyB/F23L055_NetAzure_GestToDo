using F23L055_GestToDo.Bll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Bll.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> Get();
        bool CreateUser(User user);
        string? Login(User userCred);
    }
}
