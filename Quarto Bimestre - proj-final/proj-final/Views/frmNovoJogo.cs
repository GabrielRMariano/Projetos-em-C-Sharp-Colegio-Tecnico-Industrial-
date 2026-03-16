using System;
using System.Windows.Forms;
using proj_final.Presenters;
using proj_final.Classes;

namespace proj_final.Views
{
    public partial class frmNovoJogo : Form
    {
        private Contexto db;
        private JogoPresenter presenter;

        public frmNovoJogo(Contexto db)
        {
            InitializeComponent();
            presenter = new JogoPresenter(db);
            this.db = db;
            CarregarFornecedores();
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

            Jogo novoJogo = new Jogo
            {
                Titulo = titulo,
                Genero = genero,
                Preco = preco,
                Data_lancamento = dataLancamento,
                Qtde_estoque = qtdeEstoque,
                Fornecedor = presenter.ObterFornecedorPorId(fornecedorId)
            };

            presenter.AdicionarJogo(novoJogo);

            MessageBox.Show("Jogo adicionado com sucesso!");

            this.Close();
        }
    }
}