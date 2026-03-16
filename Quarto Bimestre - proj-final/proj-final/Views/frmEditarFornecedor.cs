using System;
using System.Windows.Forms;
using proj_final.Presenters;
using proj_final.Classes;

namespace proj_final.Views
{
    public partial class frmEditarFornecedor : Form
    {
        private Contexto db;
        private FornecedorPresenter presenter;
        private Fornecedor fornecedorSelecionado;

        public frmEditarFornecedor(int idFornecedor, Contexto db)
        {
            InitializeComponent();
            this.db = db;
            presenter = new FornecedorPresenter(db);
            fornecedorSelecionado = presenter.ObterFornecedorPorId(idFornecedor);

            if (fornecedorSelecionado != null)
            {
                txtNome.Text = fornecedorSelecionado.Nome;
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado.");
                this.Close();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo Nome é obrigatório.");
                return;
            }

            fornecedorSelecionado.Nome = nome;
            presenter.EditarFornecedor(fornecedorSelecionado);

            MessageBox.Show("Fornecedor editado com sucesso!");
            this.Close();
        }

    }
}
