using ecomm1_2A.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecomm1_2A
{
    public partial class frmEditarProduto : Form
    {
        Produto produto;
        Contexto db;
        public frmEditarProduto(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            this.db = new Contexto();

            txtNome.Text = produto.Nome;
            txtDesc.Text = produto.Descricao;
            txtTipo.Text = produto.Tipo_produto;
            numValor.Value = (decimal) produto.Valor_unitario;
            numQtd.Value = (int) produto.Qtde_estoque;
            cbExcluido.Checked = produto.Excluido;
            cbExcluido.Enabled = produto.Excluido;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDesc.Text;
            produto.Tipo_produto = txtTipo.Text;
            produto.Valor_unitario = (double) numValor.Value;
            produto.Qtde_estoque = (int) numQtd.Value;
            produto.Excluido = cbExcluido.Checked;

            if (!cbExcluido.Checked)
                produto.Data_exclusao = null;

            this.db.Produto.Update(produto);
            this.db.SaveChanges();
            MessageBox.Show("Sucesso!");
            this.Close();
        }
    }
}
