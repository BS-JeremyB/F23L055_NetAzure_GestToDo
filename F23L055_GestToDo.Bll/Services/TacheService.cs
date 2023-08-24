using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Mappers;
using F23L055_GestToDo.Bll.Repositories;
using IDalTacheRepository = F23L055_GestToDo.Dal.Repositories.ITacheRepository;

namespace F23L055_GestToDo.Bll.Services
{
    public class TacheService : ITacheRepository
    {
        private readonly IDalTacheRepository _dalRepository;

        public TacheService(IDalTacheRepository dalRepository)
        {
            _dalRepository = dalRepository;
        }

        public IEnumerable<Tache> Get()
        {
            return _dalRepository.Get().Select(t => t.ToBll());
        }

        public bool CreerTache(Tache tache)
        {
            return _dalRepository.CreerTache(tache.ToDal());
        }

        public Tache? GetById(int id)
        {
            return _dalRepository.GetById(id)?.ToBll();
        }

        public bool UpdateTacheFinalise(Tache tache)
        {
            return _dalRepository.UpdateTacheFinalise(tache.ToDal());
        }

        public bool DeleteTache(int id)
        {
            Tache? tache = _dalRepository.GetById(id)?.ToBll();

            if(tache is not null)
            {
                return _dalRepository.DeleteTache(tache.ToDal());
            }

            return false;
        }
    }
}
