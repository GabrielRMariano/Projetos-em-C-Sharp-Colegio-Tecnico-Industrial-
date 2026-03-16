using System;
using System.Windows.Forms;
using proj_final.Presenters;
using proj_final.Classes;

namespace proj_final.Views
{
    public partial class frmFornecedor : Form
    {
        private FornecedorPresenter presenter;
        private Fornecedor selecionado;
        private Form anterior;

        private Contexto db;

        public frmFornecedor(Form anterior, Contexto db)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.db = db;
            presenter = new FornecedorPresenter(db); 
            Recarregar("");
        }

        private void Recarregar(string busca)
        {
            dgvFornecedor.DataSource = presenter.BuscarFornecedores(busca);
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvFornecedor.SelectedCells[0].RowIndex;
            int id_fornecedor = (int)dgvFornecedor.Rows[linha].Cells[0].Value;

            selecionado = presenter.ObterFornecedorPorId(id_fornecedor);

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (presenter.FornecedorTemJogoAssociado(selecionado.Id))
            {
                MessageBox.Show("Não é possível excluir o fornecedor porque ele está vinculado a um ou mais jogos. Por favor, remova os jogos associados antes de excluir o fornecedor.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Deseja mesmo excluir o fornecedor " + selecionado.Nome + "?", "Confirmação", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    presenter.RemoverFornecedor(selecionado);
                    MessageBox.Show("Fornecedor excluído com sucesso.");
                    Recarregar(txtBusca.Text);
                }
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            frmNovoFornecedor f = new frmNovoFornecedor(db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarFornecedor f = new frmEditarFornecedor(selecionado.Id, db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void frmFornecedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }
    }
}
