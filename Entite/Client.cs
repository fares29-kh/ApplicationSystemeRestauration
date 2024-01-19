using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoRestaurant.Entite
{
    public class Client
    {
        public int id_client { get; set; }
        public string nom_client { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        
    }
}
