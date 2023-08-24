using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Mappers;
using F23L055_GestToDo.Bll.Repositories;
using IDalUserRepository = F23L055_GestToDo.Dal.Repositories.IUserRepository;

namespace F23L055_GestToDo.Bll.Services
{
    public class UserService : IUserRepository
    {
        private readonly IDalUserRepository _dalRepository;
        private readonly IAuthRepository _authRepository;

        public UserService(IDalUserRepository dalRepository, IAuthRepository authRepository)
        {
            _dalRepository = dalRepository;
            _authRepository = authRepository;
        }

        public IEnumerable<User> Get()
        {
            return _dalRepository.Get().Select(u => u.ToBll());
        }
        public bool CreateUser(User user)
        {
            return _dalRepository.CreateUser(user.ToDal());
        }

        public string? Login(User userCred)
        {
            User? user = _dalRepository.Login(userCred.ToDal())?.ToBll();
            if(user is not null)
            {
               return _authRepository.GenerateToken(user);
            }

            return null;

        }
    }
}
