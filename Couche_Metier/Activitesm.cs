using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couche_Metier
{
   public class Activitesm
    {
        public int id { get; set; }
        public string nom_prisionner { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public string heure_debut{ get; set; }
        public string  heure_fin { get; set; }
        public string lieu{ get; set; }

    }
}
