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
    public partial class frmUsuario : Form
    {
        Contexto db;
        Form anterior;
        public frmUsuario(Form anterior)
        {
            InitializeComponent();

            this.anterior = anterior;

            this.db = new Contexto();

            Recarregar("");
        }

        public void Recarregar(string busca)
        {
            List<Usuario> usuarios = this.db.Usuario
                .Where(u => u.Nome.ToUpper().Contains(busca.ToUpper()))
                .ToList();

            dgvUsuario.DataSource = usuarios;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }

        Usuario selecionado;
        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvUsuario.SelectedCells[0].RowIndex;
            int id = (int)dgvUsuario.Rows[linha].Cells[0].Value;

            selecionado = this.db.Usuario.Where(u => u.Id == id).First();

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarUsuario f = new frmEditarUsuario(selecionado);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover o usuário " + selecionado.Nome + "?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.db.Usuario.Remove(selecionado);
                this.db.SaveChanges();

                btEditar.Enabled = false;
                btRemover.Enabled = false;

                Recarregar(txtBusca.Text);
            }
        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.db.Dispose();
            anterior.Show();
        }
    }
}
