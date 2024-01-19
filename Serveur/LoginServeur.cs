namespace ApplicationSystemeRestauration.serveur
{
	public partial class LoginServeur : Form
	{
		

		public LoginServeur()
		{
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
            DashbordServeur _dash = new DashbordServeur();
            this.Close();
            _dash.ShowDialog();
           
        }

		private void btnCancelar_Click(object sender, EventArgs e)
		{
            this.Close();
        }
	}
}
