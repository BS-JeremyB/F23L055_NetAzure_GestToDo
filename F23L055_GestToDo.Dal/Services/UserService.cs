using F23L055_GestToDo.Dal.Entities;
using F23L055_GestToDo.Dal.Mappers;
using F23L055_GestToDo.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Database;

namespace F23L055_GestToDo.Dal.Services
{

    public class UserService : IUserRepository
    {

        private readonly DbConnection _connection;

        public UserService(DbConnection connection)
        {
            _connection = connection;
        }
        public bool CreateUser(User user)
        {
            _connection.Open();
            int rows = _connection.ExecuteNonQuery("CSP_CreerUser", true, new { user.Email, user.Password });
            _connection.Close();
            return rows == 1;
        }

        public IEnumerable<User> Get()
        {
            _connection.Open();
            IEnumerable<User> result = _connection.ExecuteReader("CSP_GetUsers", (dr) => dr.ToUser(), true).ToList();
            _connection.Close();
            return result;
        }

        public User? Login(User userCred)
        {
            _connection.Open();
            User? user = _connection.ExecuteReader("CSP_Connexion", (dr) => dr.ToUser(), true, new { userCred.Email, userCred.Password }).SingleOrDefault();
            _connection.Close();

            return user is not null ? user : null;
        }
    }
}
