using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoRestaurant.Entite
{
    public class Gerant
    {
        public int id_gerant { get; set; }
        public string nom_gerant { get; set; }
        public string prenom { get; set; }
        public int cin { get; set; }
        public string password { get; set; }
        
    }
}
