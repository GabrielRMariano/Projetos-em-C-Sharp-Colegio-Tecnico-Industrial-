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
    public partial class frmGerenciarElenco : Form
    {
        Filme filme;
        Contexto db;
        Ator selecionado;

        public frmGerenciarElenco(Filme filme, Contexto db)
        {
            InitializeComponent();

            this.filme = filme;
            this.db = db;

            List<Ator> atores = this.db.Ator.ToList();
            cbxAtor.DataSource = atores;

            Recarregar();
        }

        public void Recarregar()
        {
            dgvElenco.DataSource = this.db.Ator.Where(a => a.Filmes.Contains(filme)).ToList();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            if (cbxAtor.SelectedItem != null)
            {
                Ator ator = this.db.Ator
                        .Where(a => a.Nome == cbxAtor.SelectedItem.ToString())
                        .First();
                filme.Atores.Add(ator);
                this.db.Filme.Update(filme);
                this.db.SaveChanges();

                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um ator.");
            }
            Recarregar();
        }

        private void dgvElenco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvElenco.SelectedCells[0].RowIndex;
            int id = (int) dgvElenco.Rows[linha].Cells[0].Value;

            selecionado = filme.Atores.Where(a => a.Id == id).First();

            btRemover.Enabled = true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
            "Deseja mesmo remover o ator " + selecionado.Nome + " do elenco?",
            "Confirmação",
            MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                filme.Atores.Remove(selecionado);
                this.db.SaveChanges();

                btRemover.Enabled = false;

                Recarregar();
            }
        }
    }
}
