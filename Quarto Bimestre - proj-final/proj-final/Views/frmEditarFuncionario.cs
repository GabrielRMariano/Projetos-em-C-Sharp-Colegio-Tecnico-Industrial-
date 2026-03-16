using System;
using System.Windows.Forms;
using proj_final.Presenters;
using proj_final.Classes;

namespace proj_final.Views
{
    public partial class frmEditarFuncionario : Form
    {
        private Contexto db;
        private FuncionarioPresenter presenter;
        private Funcionario funcionarioSelecionado;

        public frmEditarFuncionario(int idFuncionario, Contexto db)
        {
            InitializeComponent();
            this.db = db;
            presenter = new FuncionarioPresenter(db);
            funcionarioSelecionado = presenter.ObterFuncionarioPorId(idFuncionario);

            if (funcionarioSelecionado != null)
            {
                txtNome.Text = funcionarioSelecionado.Nome;
                txtEmail.Text = funcionarioSelecionado.Email;
                txtSenha.Text = funcionarioSelecionado.Senha;
                chkAdmin.Checked = funcionarioSelecionado.Admin;
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.");
                this.Close();
            }
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

            funcionarioSelecionado.Nome = nome;
            funcionarioSelecionado.Email = email;
            funcionarioSelecionado.Senha = senha;
            funcionarioSelecionado.Admin = admin;

            presenter.EditarFuncionario(funcionarioSelecionado);

            MessageBox.Show("Funcionário editado com sucesso!");

            this.Close();
        }
    }
}
