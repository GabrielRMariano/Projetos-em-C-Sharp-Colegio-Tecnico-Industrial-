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
    public partial class frmEditarUsuario : Form
    {
        Usuario usuario;
        Contexto db;
        public frmEditarUsuario(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
            this.db = new Contexto();

            txtNome.Text = usuario.Nome;
            txtCpf.Text = usuario.Cpf;
            txtEmail.Text = usuario.Email;
            txtTelefone.Text = usuario.Telefone;
            chkAdmin.Checked = usuario.Admin;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            usuario.Nome = txtNome.Text;
            usuario.Cpf = txtCpf.Text;
            usuario.Email = txtEmail.Text;
            usuario.Telefone = txtTelefone.Text;
            usuario.Nome = txtNome.Text;
            usuario.Admin = chkAdmin.Checked;   

            this.db.Usuario.Update(usuario);
            this.db.SaveChanges();
            MessageBox.Show("Sucesso!");
        }
    }
}
