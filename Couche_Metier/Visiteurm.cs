using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couche_Metier
{
   public  class Visiteurm
    {
        public int id { get; set; }
        public string nom_visiteur { get; set; }
        public string nom_prisonnier { get; set; }
        public string Num_cni { get; set; }
        public string sexe { get; set; }
        public string Tel{ get; set; }
        public string Lien_parente { get; set; }
        public string autorisation{ get; set; }
        public string date_visit { get; set; }
      
    }
}
