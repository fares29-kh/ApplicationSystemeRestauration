

namespace ApplicationSystemeRestauration.Gerant
{
    public partial class DashbordGerant : Form
    {


        //Constructor
        public DashbordGerant()
        {
            InitializeComponent();

        }

        






        private void button4_Click(object sender, EventArgs e)
        {
            GererProduit _dash = new GererProduit();
            _dash.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GererCategorie _dash = new GererCategorie();
            _dash.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GererTable _dash = new GererTable();
            _dash.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GererFacture _dash = new GererFacture();
            _dash.ShowDialog();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            GererFacture _dash = new GererFacture();
            _dash.ShowDialog();
        }

        private void lblNumCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
