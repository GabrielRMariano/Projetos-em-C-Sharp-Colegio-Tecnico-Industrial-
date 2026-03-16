using proj_final.Classes;
using proj_final.Presenters;
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
    public partial class frmVenda : Form
    {
        private VendaPresenter presenter;
        private Venda selecionado;
        Form anterior;
        private Contexto db;
        private Funcionario logado;
        public frmVenda(Form anterior, Contexto db, Funcionario logado)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.db = db;
            presenter = new VendaPresenter(db);
            this.logado = logado;
            Recarregar();
        }

        private void Recarregar()
        {
            dgvVendas.DataSource = presenter.BuscarVendas();
        }

        private void frmVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }


        private void dgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvVendas.SelectedCells[0].RowIndex;
            int id_venda = (int)dgvVendas.Rows[linha].Cells[0].Value;

            selecionado = presenter.ObterVendaPorId(id_venda);

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            frmNovaVenda f = new frmNovaVenda(db, logado);
            f.ShowDialog();
            Recarregar();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarVenda f = new frmEditarVenda(selecionado.Id_venda, db);
            f.ShowDialog();
            Recarregar();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover a venda " + selecionado.Id_venda + "?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                VendaJogo vj = presenter.ObterVendaJogoPorId(selecionado.Id_venda);
                int id_jogo = vj.IdProduto;
                Jogo jogo = presenter.ObterJogoPorId(id_jogo);

                presenter.ExcluirVenda(selecionado, vj, jogo);

                btEditar.Enabled = false;
                btRemover.Enabled = false;

                Recarregar();
            }
        }
    }
}
