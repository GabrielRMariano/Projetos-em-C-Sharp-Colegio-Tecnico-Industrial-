using System;
using System.Windows.Forms;
using proj_final.Presenters;
using proj_final.Classes;

namespace proj_final.Views
{
    public partial class frmEditarJogo : Form
    {
        private Contexto db;
        private JogoPresenter presenter;
        private Jogo jogoSelecionado;

        public frmEditarJogo(int idProduto, Contexto db)
        {
            InitializeComponent();
            this.db = db;
            presenter = new JogoPresenter(db);
            jogoSelecionado = presenter.ObterJogoPorId(idProduto);

            if (jogoSelecionado != null)
            {
                txtTitulo.Text = jogoSelecionado.Titulo;
                txtGenero.Text = jogoSelecionado.Genero;
                numPreco.Value = (decimal)jogoSelecionado.Preco;
                dtpDataLancamento.Value = jogoSelecionado.Data_lancamento.ToDateTime(new TimeOnly());
                numQtdeEstoque.Value = jogoSelecionado.Qtde_estoque;
                CarregarFornecedores();
                cboFornecedor.SelectedValue = jogoSelecionado.Fornecedor.Id;
            }
            else
            {
                MessageBox.Show("Jogo não encontrado.");
                this.Close();
            }
        }

        private void CarregarFornecedores()
        {
            var fornecedores = presenter.ObterFornecedores();
            cboFornecedor.DataSource = fornecedores;
            cboFornecedor.DisplayMember = "Nome";
            cboFornecedor.ValueMember = "Id";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string genero = txtGenero.Text;
            double preco = (double)numPreco.Value;
            DateOnly dataLancamento = DateOnly.FromDateTime(dtpDataLancamento.Value);
            int qtdeEstoque = (int)numQtdeEstoque.Value;
            int fornecedorId = (int)cboFornecedor.SelectedValue;

            jogoSelecionado.Titulo = titulo;
            jogoSelecionado.Genero = genero;
            jogoSelecionado.Preco = preco;
            jogoSelecionado.Data_lancamento = dataLancamento;
            jogoSelecionado.Qtde_estoque = qtdeEstoque;
            jogoSelecionado.Fornecedor = presenter.ObterFornecedorPorId(fornecedorId);

            presenter.EditarJogo(jogoSelecionado);

            MessageBox.Show("Jogo editado com sucesso!");

            this.Close();
        }
    }
}