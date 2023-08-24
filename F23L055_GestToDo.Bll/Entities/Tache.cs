using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Bll.Entities
{
    public class Tache
    {
        public int Id { get; init; }
        public string Titre { get; set; }
        public bool Finalise { get; set; }
        public int Responsable { get; set; }

        public Tache(string titre, int responsable)
        {
            Titre = titre;
            Responsable = responsable;
        }
 
        public Tache(int id, bool finalise, int responsable)
        {
            Id = id;
            Finalise = finalise;
            Responsable = responsable;
        }
        internal Tache(int id, string titre, bool finalise, int responsable)
        {
            Id = id;
            Titre = titre;
            Finalise = finalise;
            Responsable = responsable;
        }

    }
}
