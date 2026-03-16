using System;
using System.Windows.Forms;
using proj_final.Presenters;
using proj_final.Classes;

namespace proj_final.Views
{
    public partial class frmNovoFornecedor : Form
    {
        private Contexto db;
        private FornecedorPresenter presenter;

        public frmNovoFornecedor(Contexto db)
        {
            InitializeComponent();
            presenter = new FornecedorPresenter(db);
            this.db = db;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O nome do fornecedor é obrigatório.");
                return;
            }

            Fornecedor novoFornecedor = new Fornecedor
            {
                Nome = nome
            };

            presenter.AdicionarFornecedor(novoFornecedor);

            MessageBox.Show("Fornecedor adicionado com sucesso!");

            this.Close();
        }
    }
}
