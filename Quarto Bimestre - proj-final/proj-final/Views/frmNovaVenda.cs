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
    public partial class frmNovaVenda : Form
    {
        private Contexto db;
        private VendaPresenter presenter;
        private JogoPresenter jogo_presenter;
        private CompraPresenter compra_presenter;
        private Jogo jogo_selecionado;
        private Funcionario logado;
        public frmNovaVenda(Contexto db, Funcionario logado)
        {
            InitializeComponent();
            presenter = new VendaPresenter(db);
            jogo_presenter = new JogoPresenter(db);
            compra_presenter = new CompraPresenter(db);
            this.db = db;
            this.logado = logado;
            CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {
            var fornecedores = compra_presenter.ObterFornecedores();
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
            DateOnly dataVenda = DateOnly.FromDateTime(dtpDataVenda.Value);
            int qtd = (int)numQtd.Value;


            Venda novaVenda = new Venda
            {
                Data_venda = dataVenda,
                Funcionario = logado
            };

            presenter.AdicionarVenda(novaVenda, jogo, qtd);

            MessageBox.Show("Venda adicionada com sucesso!");

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
