using System;
using System.Windows.Forms;
using proj_final.Presenters;
using proj_final.Classes;

namespace proj_final.Views
{
    public partial class frmFuncionario : Form
    {
        private FuncionarioPresenter presenter;
        private Funcionario selecionado;
        private Form anterior;
        private Contexto db;

        public frmFuncionario(Form anterior, Contexto db)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.db = db;
            presenter = new FuncionarioPresenter(db);
            Recarregar("");
        }

        private void Recarregar(string busca)
        {
            dgvFuncionario.DataSource = presenter.BuscarFuncionarios(busca);
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvFuncionario.SelectedCells[0].RowIndex;
            int id_funcionario = (int)dgvFuncionario.Rows[linha].Cells[0].Value;

            selecionado = presenter.ObterFuncionarioPorId(id_funcionario);

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover o funcionário " + selecionado.Nome + "?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                presenter.RemoverFuncionario(selecionado);

                btEditar.Enabled = false;
                btRemover.Enabled = false;

                Recarregar(txtBusca.Text);
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            frmNovoFuncionario f = new frmNovoFuncionario(db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarFuncionario f = new frmEditarFuncionario(selecionado.Id, db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void frmFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }
    }
}
