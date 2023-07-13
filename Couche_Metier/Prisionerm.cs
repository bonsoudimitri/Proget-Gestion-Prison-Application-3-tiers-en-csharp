using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Couche_Metier
{
   public  class Prisonierm
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string sexe { get; set; }
        public string prison{ get; set; }
        public  string datenais { get; set; }
        public string date_integration{ get; set; }
        public string  date_liberation{ get; set; }
        public string etat_sante { get; set; }
        public string photo { get; set; }
    }
}
