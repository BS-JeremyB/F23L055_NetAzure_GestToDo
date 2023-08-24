using F23L055_GestToDo.Bll.Entities;
using DalTache = F23L055_GestToDo.Dal.Entities.Tache;
using DalUser = F23L055_GestToDo.Dal.Entities.User;

namespace F23L055_GestToDo.Bll.Mappers
{
    internal static class Mappers
    {
        internal static DalTache ToDal(this Tache entity)
        {
            return new DalTache() { Id = entity.Id, Titre = entity.Titre, Finalise = entity.Finalise, Responsable = entity.Responsable };
        }

        internal static Tache ToBll(this DalTache entity)
        {
            return new Tache(entity.Id, entity.Titre, entity.Finalise, entity.Responsable);
        }

        internal static DalUser ToDal(this User user)
        {
            return new DalUser() { Id = user.Id, Email = user.Email, Password = user.Password, Role = user.Role};
        }

        internal static User ToBll(this DalUser user)
        {
            return new User(user.Id, user.Email, user.Role);
        }

    }
}
