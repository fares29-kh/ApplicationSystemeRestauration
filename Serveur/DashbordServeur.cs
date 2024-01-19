using DaoRestaurant.Entite;

namespace ApplicationSystemeRestauration.serveur
{
    public partial class DashbordServeur : Form
    {
        HttpClient client;
      public  List<Table> listeTables=new List<Table>();
     
        //Constructor
        public DashbordServeur()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7063/api/");
            HttpResponseMessage response = client.GetAsync("table").Result;
            var table = response.Content.ReadAsAsync<List<Table>>().Result;


            listeTables = table;
            Console.WriteLine(listeTables);
            InitializeComponent();

        }

        private void DashbordServeur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListeFacture _fact = new ListeFacture();

            _fact.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FactureDeTable _facturetable = new FactureDeTable();
            _facturetable.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListeFacture _fact = new ListeFacture();
            
            _fact.ShowDialog();
        }


        private void payer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void commande_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public  void reserver_Click(object sender, EventArgs e)
        {

            Panel panel = (Panel)sender;
            Table table = new Table();
            table.num_table = Convert.ToInt32(""+panel.Name);
            table.status = 0;
            table.NombreMax = 4;
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7063/api/Table/");
            HttpResponseMessage response = client.PutAsJsonAsync(""+panel.Name, table).Result;

            

            DashbordServeur _dash = new DashbordServeur();

            _dash.ShowDialog();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
