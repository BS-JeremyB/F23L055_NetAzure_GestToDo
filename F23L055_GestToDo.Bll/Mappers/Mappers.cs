using F23L055_GestToDo.Bll.Entities;
using DalTache = F23L055_GestToDo.Dal.Entities.Tache;

namespace F23L055_GestToDo.Bll.Mappers
{
    internal static class Mappers
    {
        internal static DalTache ToDal(this Tache entity)
        {
            return new DalTache() { Id = entity.Id, Titre = entity.Titre, Finalise = entity.Finalise };
        }

        internal static Tache ToBll(this DalTache entity)
        {
            return new Tache(entity.Id, entity.Titre, entity.Finalise);
        }
    }
}
