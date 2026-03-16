using System;
using System.Windows.Forms;
using proj_final.Classes;

namespace proj_final.Views
{
    public partial class frmMenu : Form
    {
        private Contexto db; 

        public frmMenu(Contexto db)
        {
            InitializeComponent();
            this.db = db; 
        }

        private void btJogo_Click(object sender, EventArgs e)
        {
            frmJogo f = new frmJogo(this, db);
            f.Show();
            this.Hide();
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario f = new frmFuncionario(this, db); 
            f.Show();
            this.Hide();
        }

        private void btFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor f = new frmFornecedor(this, db); 
            f.Show();
            this.Hide();
        }

        private void btOperacoes_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin(this, db);
            f.Show();
            this.Hide();
        }
    }
}
