namespace ApplicationSystemeRestauration.Gerant
{
	public partial class LoginGerant : Form
	{


		public LoginGerant()
		{
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
            DashbordGerant _dash = new DashbordGerant();
            _dash.ShowDialog();
        }

		private void btnCancelar_Click(object sender, EventArgs e)
		{
            this.Close();
        }
	}
}