using proj_final.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_final.Views
{
    public partial class frmMenuOperacoes : Form
    {
        private Form anterior;
        private Contexto db;
        private Funcionario selecionado;
        public frmMenuOperacoes(Form anterior, Contexto db, Funcionario selecionado)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.db = db;
            this.selecionado = selecionado;
            btCompras.Enabled = (selecionado.Admin); //só pode acessar o frmCompras se for admin
        }


        private void frmMenuOperacoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }

        private void btCompras_Click(object sender, EventArgs e)
        {
            frmCompra f = new frmCompra(this, db);
            f.Show();
            this.Hide();
        }

        private void btVendas_Click(object sender, EventArgs e)
        {
            frmVenda f = new frmVenda(this, db, selecionado);
            f.Show();
            this.Hide();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }
    }
}
