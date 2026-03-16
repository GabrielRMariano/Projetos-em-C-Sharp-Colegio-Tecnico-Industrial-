using filmesApp2A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp2A
{
    public partial class frmFilmes : Form
    {
        Contexto db;
        Form anterior;
        public frmFilmes(Form anterior)
        {
            InitializeComponent();

            this.anterior = anterior;

            this.db = new Contexto();
            this.db.Database.EnsureCreated();
            Recarregar("");
        }

        public void Recarregar(string busca)
        {
            List<Filme> filmes = this.db.Filme
                .Where(a => a.Nome.ToUpper().Contains(busca.ToUpper()))
                .ToList();

            dgvFilmes.DataSource = filmes;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoFilme f = new frmNovoFilme(db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        Filme selecionado;
        private void dgvFilmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvFilmes.SelectedCells[0].RowIndex;
            int id = (int)dgvFilmes.Rows[linha].Cells[0].Value;

            selecionado = this.db.Filme.Where(a => a.Id == id).First();

            btEditar.Enabled = true;
            btRemover.Enabled = true;
            btGerenciar.Enabled = true;
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            frmGerenciarElenco f = new frmGerenciarElenco(selecionado, db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);

        }

        private void frmFilmes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.db.Dispose();
            anterior.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarFilme f = new frmEditarFilme(selecionado, db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover o filme " + selecionado.Nome + "?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.db.Filme.Remove(selecionado);
                this.db.SaveChanges();

                btEditar.Enabled = false;
                btRemover.Enabled = false;

                Recarregar(txtBusca.Text);
            }
        }
    }
}
