namespace ecomm1_2A
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario f = new frmUsuario(this);
            f.Show();
            this.Hide();
        }

        private void btCompra_Click(object sender, EventArgs e)
        {
            frmCompra f = new frmCompra(this);
            f.Show();
            this.Hide();
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            frmProduto f = new frmProduto(this);
            f.Show();
            this.Hide();
        }
    }
}
