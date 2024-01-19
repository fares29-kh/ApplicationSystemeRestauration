using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoRestaurant.Entite
{
    public class Service
    {
        public int id_service { get; set; }
        public string Nom_service { get; set; }
        public string description_service { get; set; }
       
        public double prix { get; set; }
        public string image { get; set; }

        public int id_categorie { get; set; }

    }
}
