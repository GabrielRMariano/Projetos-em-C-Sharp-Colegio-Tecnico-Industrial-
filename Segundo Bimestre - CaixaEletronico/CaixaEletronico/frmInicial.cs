namespace CaixaEletronico
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btAdm_Click(object sender, EventArgs e)
        {
            frmAdm f = new frmAdm();
            f.Show();
            this.Hide();
        }

        private void btCaixa_Click(object sender, EventArgs e)
        {

        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }

        private void frmInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
