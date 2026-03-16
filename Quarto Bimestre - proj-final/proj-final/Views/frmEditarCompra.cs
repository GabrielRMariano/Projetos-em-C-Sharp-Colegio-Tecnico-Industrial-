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
    public partial class frmEditarCompra : Form
    {
        private Contexto db;
        private CompraPresenter presenter;
        private JogoPresenter jogo_presenter;
        private Compras compraSelecionada;
        private ComprasJogo cj;
        private Jogo jogo;
        public frmEditarCompra(int idCompra, Contexto db)
        {
            InitializeComponent();
            this.db = db;
            presenter = new CompraPresenter(db);
            jogo_presenter = new JogoPresenter(db);
            compraSelecionada = presenter.ObterCompraPorId(idCompra);

            if (compraSelecionada != null)
            {
                cj = presenter.ObterCompraJogoPorId(idCompra);
                dtpDataCompra.Value = compraSelecionada.Data_compra.ToDateTime(new TimeOnly());
                numQtd.Value = cj.Quantidade;
                jogo = jogo_presenter.ObterJogoPorId(cj.IdProduto);
            }
            else
            {
                MessageBox.Show("Compra não encontrada.");
                this.Close();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            
            DateOnly dataCompra = DateOnly.FromDateTime(dtpDataCompra.Value);
            int qtd = (int)numQtd.Value;
            int qtdeAntiga = cj.Quantidade;
            int varQtde = qtd-qtdeAntiga;

            compraSelecionada.Data_compra = dataCompra;
            
            cj.Quantidade = qtd;
            cj.ValorPago = cj.Quantidade * jogo.Preco;
            jogo.Qtde_estoque += varQtde;

            presenter.EditarCompra(compraSelecionada, cj, jogo);

            MessageBox.Show("Compra editada com sucesso!");

            this.Close();
        }
    }
}
