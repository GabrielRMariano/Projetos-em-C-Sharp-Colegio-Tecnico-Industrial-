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
    public partial class frmEditarVenda : Form
    {
        private Contexto db;
        private VendaPresenter presenter;
        private JogoPresenter jogo_presenter;
        private Venda vendaSelecionada;
        private VendaJogo vj;
        private Jogo jogo;
        public frmEditarVenda(int idVenda, Contexto db)
        {
            InitializeComponent();
            this.db = db;
            presenter = new VendaPresenter(db);
            jogo_presenter = new JogoPresenter(db);
            vendaSelecionada = presenter.ObterVendaPorId(idVenda);

            if (vendaSelecionada != null)
            {
                vj = presenter.ObterVendaJogoPorId(idVenda);
                dtpDataVenda.Value = vendaSelecionada.Data_venda.ToDateTime(new TimeOnly());
                numQtd.Value = vj.Quantidade;
                jogo = jogo_presenter.ObterJogoPorId(vj.IdProduto);
            }
            else
            {
                MessageBox.Show("Venda não encontrada.");
                this.Close();
            }
        }

        private void btSalvarVenda_Click(object sender, EventArgs e)
        {
            DateOnly dataVenda = DateOnly.FromDateTime(dtpDataVenda.Value);
            int qtd = (int)numQtd.Value;
            int qtdeAntiga = vj.Quantidade;
            int varQtde = qtd - qtdeAntiga;

            vendaSelecionada.Data_venda = dataVenda;

            vj.Quantidade = qtd;
            vj.ValorPago = vj.Quantidade * jogo.Preco;
            jogo.Qtde_estoque -= varQtde;

            presenter.EditarVenda(vendaSelecionada, vj, jogo);

            MessageBox.Show("Venda editada com sucesso!");

            this.Close();
        }
    }
}
