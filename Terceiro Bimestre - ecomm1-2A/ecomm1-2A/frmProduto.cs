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
using ecomm1_2A.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ecomm1_2A
{
    public partial class frmProduto : Form
    {
        Contexto db;
        Form anterior;

        public frmProduto(Form anterior)
        {
            InitializeComponent();

            this.anterior = anterior;

            this.db = new Contexto();
            Recarregar("");
        }

        public void Recarregar(string busca)
        {
            List<Produto> produtos = this.db.Produto
                .Where(p => p.Nome.ToUpper().Contains(busca.ToUpper()))
                .ToList();

            dgvProduto.DataSource = produtos;

        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }

        Produto selecionado;
        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvProduto.SelectedCells[0].RowIndex;
            int id = (int)dgvProduto.Rows[linha].Cells[0].Value;

            selecionado = this.db.Produto.Where(p => p.Id == id).First();

            btEditar.Enabled = true;
            btRelEstoque.Enabled = true;

            if (selecionado.Excluido)
                btRemover.Enabled = false;
            else
                btRemover.Enabled = true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover o produto " + selecionado.Nome + "?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            

            if (r == DialogResult.Yes)
            {
                selecionado.Excluido = true;
                selecionado.Data_exclusao = DateOnly.FromDateTime(DateTime.Now);
                this.db.Produto.Update(selecionado);
                this.db.SaveChanges();

                btEditar.Enabled = false;
                btRemover.Enabled = false;
                btRelEstoque.Enabled = false;

                Recarregar(txtBusca.Text);
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            frmNovoProduto f = new frmNovoProduto();
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarProduto f = new frmEditarProduto(selecionado);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void frmProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.db.Dispose();
            anterior.Show();
        }

        private void btRelEstoque_Click(object sender, EventArgs e)
        {
            Produto p = db.Produto.Include(p => p.Compras).ThenInclude(cp => cp.Compra).ThenInclude(c => c.Comprador).First(p => p.Id == selecionado.Id);
            string qtd = Interaction.InputBox("Quantidade inicial",
                                                "Geração de relatório", "100");
            MovEstoque.Gerar(p, Int32.Parse(qtd));
        }
    }
}
