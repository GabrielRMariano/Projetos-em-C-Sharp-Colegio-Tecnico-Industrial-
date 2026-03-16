namespace ORastroDoCoelho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            txtFinal.Text = Cripto.Descriptografar(txtOriginal.Text);
            rastropt2 rastropt2 = new rastropt2();
            rastropt2.Show();
        }

        private void txtOriginal_TextChanged(object sender, EventArgs e)
        {
            btProcessar.Enabled = txtOriginal.Text.Length > 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
