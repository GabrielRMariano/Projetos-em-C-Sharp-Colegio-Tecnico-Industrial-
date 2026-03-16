using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ecomm1_2A.classes;

namespace ecomm1_2A
{
    public partial class frmCompra : Form
    {
        Contexto db;
        Form anterior;
        public frmCompra(Form anterior)
        {
            InitializeComponent();

            this.anterior = anterior;

            this.db = new Contexto();
            Recarregar("");
        }

        public void Recarregar(string busca)
        {
            List<Compra> compras = this.db.Compra
                .Where(c => c.Sessao.ToUpper().Contains(busca.ToUpper()))
                .ToList();

            dgvCompra.DataSource = compras;
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }

        Compra selecionado;
        private void dgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvCompra.SelectedCells[0].RowIndex;
            int id = (int)dgvCompra.Rows[linha].Cells[0].Value;

            selecionado = this.db.Compra.Where(c => c.Id == id).First();

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarCompra f = new frmEditarCompra(selecionado);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover a compra da sessão " + selecionado.Sessao + "?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.db.Compra.Remove(selecionado);
                this.db.SaveChanges();

                btEditar.Enabled = false;
                btRemover.Enabled = false;

                Recarregar(txtBusca.Text);
            }
        }

        private void frmCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.db.Dispose();
            anterior.Show();
        }
    }
}
