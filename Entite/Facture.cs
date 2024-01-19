using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoRestaurant.Entite
{
   public class Facture
    {
        public int id_facture { get; set; }
        public int id_client { get; set; }
        public int id_serveur { get; set; }

        public int num_table { get; set; }
        public double prix_total { get; set; }

        public int payer { get; set; }
    }
}
