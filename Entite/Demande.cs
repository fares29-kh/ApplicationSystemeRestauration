using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoRestaurant.Entite
{
    public class Demande
    {
        public int IdDemande { get; set; }
        public int IdService { get; set; }
        public int IdClient { get; set; }
        public int NumTable { get; set; }
        public DateTime Date { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Service IdServiceNavigation { get; set; }
        public virtual Table NumTableNavigation { get; set; }

    }
}
