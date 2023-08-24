// See https://aka.ms/new-console-template for more information
using IDalTacheRepository = F23L055_GestToDo.Dal.Repositories.ITacheRepository;
using DalTacheService = F23L055_GestToDo.Dal.Services.TacheService;
using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Services;
using System.Data.Common;
using System.Data.SqlClient;
using F23L055_GestToDo.Bll.Repositories;
using DalTache = F23L055_GestToDo.Dal.Entities.Tache;

using (DbConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=F23L055_GestToDo;Integrated Security=True;"))
{
    IDalTacheRepository dalTacheRepository = new DalTacheService(connection);
    ITacheRepository tacheRepository = new TacheService(dalTacheRepository);


    #region test Creation de tache
    //Tache tache = new Tache("Test Bll");
    //tacheRepository.CreerTache(tache);
    #endregion

    #region Test Recuperation des taches
    //foreach(Tache tache in tacheRepository.Get())
    //{
    //    Console.WriteLine(tache.Titre);
    //}
    #endregion

    #region Test Recuperation d'une tache
    //Console.WriteLine(tacheRepository.GetById(1).Titre);
    #endregion

    #region Test Update d'une Tache
    //Tache tache = new Tache(1,false);
    //tacheRepository.UpdateTacheFinalise(tache);
    #endregion

    #region Delete une Tache (DAL)
    //DalTache tache = new DalTache() { Id = 3};
    //dalTacheRepository.DeleteTache(tache);
    #endregion

    #region Delete une Tache (BLL)
    //tacheRepository.DeleteTache(4);
    #endregion
}
