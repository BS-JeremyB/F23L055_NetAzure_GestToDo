using F23L055_GestToDo.Dal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Bll.Entities
{
    public class User
    {

        public int Id { get; init; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }


        public User(string email, string password) 
        {
            Email = email;
            Password = password;
        }

        public User(int id, string email, Roles role) 
        { 
            Id = id;
            Email = email;
            Role = role;
        }
        internal User(int id, string email, string password, Roles role)
        {
            Id = id;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
