using proj_final.Classes;
using proj_final.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_final.Views
{
    public partial class frmLogin : Form
    {
        private FuncionarioPresenter presenter;
        private Funcionario selecionado;
        private Form anterior;
        private Contexto db;
        public frmLogin(Form anterior, Contexto db)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.db = db;
            presenter = new FuncionarioPresenter(db);
        }

        bool CheckInfo(string email, string senha)
        {
            selecionado = presenter.ObterFuncionarioPorEmail(email);
            return selecionado.Senha == senha;
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text;
            string senha = mtxtSenha.Text;

            if (CheckInfo(email, senha))
            {
                MessageBox.Show("Informações válidas");
                frmMenuOperacoes f = new frmMenuOperacoes(anterior, db, selecionado); //enviando o frmMenu e o usuario
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Informações inválidas");
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }
    }
}
