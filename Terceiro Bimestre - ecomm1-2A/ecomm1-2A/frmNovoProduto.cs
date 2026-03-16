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
    public partial class frmNovoProduto : Form
    {
        Contexto db;
        public frmNovoProduto()
        {
            InitializeComponent();
            this.db = new Contexto();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Produto novo = new Produto();
            novo.Nome = txtNome.Text;
            novo.Descricao = txtDesc.Text;
            novo.Tipo_produto = txtTipo.Text;
            novo.Valor_unitario = (double) numValor.Value;
            novo.Qtde_estoque = (int) numQtd.Value;
            novo.Excluido = false;

            this.db.Produto.Add(novo);
            this.db.SaveChanges();

            MessageBox.Show("Sucesso!");
            this.Close();
        }
    }
}
