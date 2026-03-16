using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
using proj_final.Classes;
using proj_final.Helpers;
using proj_final.Presenters;

namespace proj_final.Views
{
    public partial class frmJogo : Form
    {
        private JogoPresenter presenter;
        private Jogo selecionado;
        Form anterior;
        private Contexto db;

        public frmJogo(Form anterior, Contexto db)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.db = db;
            presenter = new JogoPresenter(db);
            Recarregar("");
        }

        private void Recarregar(string busca)
        {
            dgvJogo.DataSource = presenter.BuscarJogos(busca);
        }

        private void dgvJogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvJogo.SelectedCells[0].RowIndex;
            int id_produto = (int)dgvJogo.Rows[linha].Cells[0].Value;

            selecionado = presenter.ObterJogoPorId(id_produto);

            btEditar.Enabled = true;
            btRelEstoque.Enabled = true;
            btRemover.Enabled = true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover o jogo " + selecionado.Titulo + "?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                presenter.ExcluirJogo(selecionado);

                btEditar.Enabled = false;
                btRemover.Enabled = false;
                btRelEstoque.Enabled = false;

                Recarregar(txtBusca.Text);
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            frmNovoJogo f = new frmNovoJogo(db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarJogo f = new frmEditarJogo(selecionado.Id, db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void frmJogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }

        private void btRelEstoque_Click(object sender, EventArgs e)
        {
            Jogo j = db.Jogo.First(j => j.Id == selecionado.Id);
            string qtd = Interaction.InputBox("Quantidade inicial",
                                                "Geração de relatório", "100");
            MovEstoque.Gerar(j, Int32.Parse(qtd));
        }
    }
}
