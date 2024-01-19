using ApplicationSystemeRestauration.Entite;
using DaoRestaurant.Entite;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ApplicationSystemeRestauration.Gerant
{
    public partial class GererProduit : Form
    {
        HttpClient client;

        public GererProduit()
        {


            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7063/api/Service");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            getservice();
            InitializeComponent();
           
        }
        private async void getservice()

        {
            var response = await client.GetStringAsync("service");
            var service = JsonConvert.DeserializeObject<List<Service>>(response);
            listeservice.DataSource = service;
        }
        private async void Saveservice(Service service)
        {

            await client.PostAsJsonAsync("service",service);

        }
        private async void Deleteservice(int id)
        {

            await client.DeleteAsync("service/" + id);

        }
        private async void updateservice(Service service)
        {

            await client.PutAsJsonAsync("service/" + service.id_service, service);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveservice_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.id_service = Int32.Parse(txtserviceid.Text);
            service.prix = Int32.Parse(txtprixservice.Text);
            service.description_service = txtdescription.Text;
            service.image=txtimageservice.Text;
            service.Nom_service=txtnomservice.Text;
            service.id_categorie = 1;
            this.Saveservice(service);
            getservice();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Deleteservice_Click(object sender, EventArgs e)
        {
            this.Deleteservice(Int32.Parse(txtserviceid.Text));
            getservice();
        }

        private void updateservice_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.id_service = Int32.Parse(txtserviceid.Text);
            service.prix = Int32.Parse(txtprixservice.Text);
            service.image = "hjgdj,gs";
            service.Nom_service = txtnomservice.Text;
            service.id_categorie = 1;
            this.updateservice(service);
            getservice();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void imageservice_Click(object sender, EventArgs e)
        {

        }

        private void GererProduit_Load(object sender, EventArgs e)
        {

        }

        private void listeservice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}