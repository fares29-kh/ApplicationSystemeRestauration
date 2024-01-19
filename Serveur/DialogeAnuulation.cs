using DaoRestaurant.Entite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSystemeRestauration.serveur
{
    public partial class DialogeAnuulation : Form
    {
        HttpClient client;

        public Table table;

        public DialogeAnuulation(int num,int nbr)
        {
           // table = new Table();

          //  table.num_table = num;
          //  table.NombreMax = nbr;
          //  table.status = 0;

            InitializeComponent();
        }

        private void ReceiveDialog_Load(object sender, EventArgs e)
        {

        }

      

        private void btnReceive_Click(object sender, EventArgs e)
        {
           
           
            
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7233/api/");
            HttpResponseMessage response = client.PutAsJsonAsync("tabel",this.table).Result;

            this.DialogResult = DialogResult.Cancel;
            DashbordServeur _dash = new DashbordServeur();
            
            _dash.ShowDialog();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtReference_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupInvoice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtReceivedDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblnumtable_Click(object sender, EventArgs e)
        {

        }
    }
}
