using ApplicationSystemeRestauration.Entite;
using DaoRestaurant.Entite;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Http.Json;


namespace ApplicationSystemeRestauration.Gerant
{
    public partial class GererCategorie : Form
    {
        HttpClient client;

        public GererCategorie()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7063/api/Categorie");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            getcategorie();


            InitializeComponent();

          


        }



        private  void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void getcategorie()

        {
            var response = await client.GetStringAsync("categorie");
            var categorie = JsonConvert.DeserializeObject<List<Categorie>>(response);
            listecategorie.DataSource = categorie;
}
        private async void SaveCategorie(Categorie categorie)
        {
          
            await client.PostAsJsonAsync("categorie", categorie);

        }
        private async void DeleteCategorie(int id)
        {
          
            await client.DeleteAsync("categorie/"+id);

        }
        private async void updateCategorie(Categorie categorie)
        {
           
            await client.PutAsJsonAsync("categorie/"+categorie.id_categorie, categorie);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listecategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private  void savecategorie_Click(object sender, EventArgs e)
        {

            string id = txtidcategorie.Text;
            string nom = txtnomcategorie.Text;
            Categorie categorie = new Categorie();
            categorie.nom_categorie = nom;
            categorie.id_categorie = Int32.Parse(id);
            this.SaveCategorie(categorie);
            getcategorie();




        }
      

        private void editcategorie_Click(object sender, EventArgs e)
        {
            string id = txtidcategorie.Text;
            string nom = txtnomcategorie.Text;
            Categorie categorie = new Categorie();
            categorie.nom_categorie = nom;
            categorie.id_categorie = Int32.Parse(id);
            updateCategorie(categorie);
            getcategorie();
        }

        private void deletecategorie_Click(object sender, EventArgs e)
        {
            string id = txtidcategorie.Text;
            DeleteCategorie(Int32.Parse(id));
            getcategorie();
        }

        private void listecategorie_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}