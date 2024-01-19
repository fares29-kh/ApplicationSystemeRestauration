using ApplicationSystemeRestauration.Gerant;
using ApplicationSystemeRestauration.serveur;

namespace ApplicationSystemeRestauration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginServeur _login = new LoginServeur();
            _login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginGerant _login = new LoginGerant();
            _login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}