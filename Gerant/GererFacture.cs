using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSystemeRestauration.Gerant
{
    public partial class GererFacture : Form
    {
      
        public GererFacture()
        {
          
            InitializeComponent();
           
              
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
