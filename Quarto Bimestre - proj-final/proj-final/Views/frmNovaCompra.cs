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
    public partial class frmNovaCompra : Form
    {
        private Contexto db;
        private CompraPresenter presenter;
        private JogoPresenter jogo_presenter;
        private Jogo jogo_selecionado;
        public frmNovaCompra(Contexto db)
        {
            InitializeComponent();
            presenter = new CompraPresenter(db);
            jogo_presenter = new JogoPresenter(db);
            this.db = db;
            CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {
            var fornecedores = presenter.ObterFornecedores();
            cbxFornecedor.DataSource = fornecedores;
            cbxFornecedor.DisplayMember = "Nome";
        }

        private void CarregarJogosPorFornecedor()
        {
            if (cbxFornecedor.SelectedValue != null)
            {
                Fornecedor forn = (Fornecedor)cbxFornecedor.SelectedValue;
                var jogos = jogo_presenter.ObterJogosPorFornecedor(forn.Id);
                cbxJogo.DataSource = jogos;
                cbxJogo.DisplayMember = "Titulo";
                cbxJogo.ValueMember = "Id";
                cbxJogo.SelectedIndex = -1;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            int id_jogo = (Int32)cbxJogo.SelectedValue;
            Jogo jogo = jogo_presenter.ObterJogoPorId(id_jogo);
            DateOnly dataCompra = DateOnly.FromDateTime(dtpDataCompra.Value);
            int fornecedorId = jogo.Fornecedor.Id;
            int qtd = (int)numQtd.Value;


            Compras novaCompra = new Compras
            {
                Data_compra = dataCompra,
                Fornecedor = presenter.ObterFornecedorPorId(fornecedorId)
            };

            presenter.AdicionarCompra(novaCompra, jogo, qtd);

            MessageBox.Show("Compra adicionada com sucesso!");

            this.Close();
        }

        private void cbxFornecedor_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarJogosPorFornecedor();

            btSalvar.Enabled = false;
        }

        private void cbxJogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btSalvar.Enabled = (cbxJogo.SelectedIndex != -1);

            if (cbxJogo.SelectedIndex == -1)
                cbxJogo.Text = "";
        }
    }
}
