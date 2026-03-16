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
    public partial class frmCompra : Form
    {
        private CompraPresenter presenter;
        private Compras selecionado;
        Form anterior;
        private Contexto db;
        public frmCompra(Form anterior, Contexto db)
        {
            InitializeComponent();
            this.anterior = anterior;
            presenter = new CompraPresenter(db);
            this.db = db;
            Recarregar();
        }

        private void Recarregar()
        {
            dgvCompras.DataSource = presenter.BuscarCompras();
        }

        private void frmCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvCompras.SelectedCells[0].RowIndex;
            int id_compra = (int)dgvCompras.Rows[linha].Cells[0].Value;

            selecionado = presenter.ObterCompraPorId(id_compra);

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            frmNovaCompra f = new frmNovaCompra(db);
            f.ShowDialog();
            Recarregar();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarCompra f = new frmEditarCompra(selecionado.Id, db);
            f.ShowDialog();
            Recarregar();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover a compra " + selecionado.Id + "?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                ComprasJogo cj = presenter.ObterCompraJogoPorId(selecionado.Id);
                int id_jogo = cj.IdProduto;
                Jogo jogo = presenter.ObterJogoPorId(id_jogo);

                presenter.ExcluirCompra(selecionado, cj, jogo);

                btEditar.Enabled = false;
                btRemover.Enabled = false;

                Recarregar();
            }
        }
    }
}
