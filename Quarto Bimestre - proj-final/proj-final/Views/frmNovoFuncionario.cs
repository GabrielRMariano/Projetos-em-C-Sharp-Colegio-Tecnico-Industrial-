using System;
using System.Windows.Forms;
using proj_final.Presenters;
using proj_final.Classes;
using iText.StyledXmlParser.Jsoup.Nodes;

namespace proj_final.Views
{
    public partial class frmNovoFuncionario : Form
    {
        private Contexto db;
        private FuncionarioPresenter presenter;

        public frmNovoFuncionario(Contexto db)
        {
            InitializeComponent();
            presenter = new FuncionarioPresenter(db);
            this.db = db;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            bool admin = chkAdmin.Checked;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }

            Funcionario novoFuncionario = new Funcionario
            {
                Nome = nome,
                Email = email,
                Senha = senha,
                Admin = admin
            };

            presenter.AdicionarFuncionario(novoFuncionario);

            MessageBox.Show("Funcionário adicionado com sucesso!");

            this.Close();
        }
    }
}
