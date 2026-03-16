using proj_final.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_final.Presenters
{
    public class CompraPresenter
    {
        private Contexto db;
        private JogoPresenter jogo_presenter;

        public CompraPresenter(Contexto db)
        {
            this.db = db;
            jogo_presenter = new JogoPresenter(db);
        }

        public void ExcluirCompra(Compras compra, ComprasJogo cj, Jogo jogo)
        {
            jogo.Qtde_estoque -= cj.Quantidade;
            jogo_presenter.EditarJogo(jogo);

            db.ComprasJogo.Remove(cj);
            db.Compras.Remove(compra);
            db.SaveChanges();
        }

        public void AdicionarCompra(Compras compra, Jogo jogo, int qtd)
        {
            db.Compras.Add(compra);
            db.SaveChanges();

            jogo.Qtde_estoque += qtd;
            db.Jogo.Update(jogo);
            db.SaveChanges();

            ComprasJogo cj = new ComprasJogo();
            cj.IdCompra = compra.Id;
            cj.IdFornecedor = compra.Fornecedor.Id;
            cj.Quantidade = qtd;
            cj.ValorPago = qtd * jogo.Preco;
            cj.IdProduto = jogo.Id;
            db.ComprasJogo.Add(cj);

            db.SaveChanges();
        }

        public void EditarCompra(Compras compra, ComprasJogo cj, Jogo jogo)
        {
            db.Compras.Update(compra);
            db.ComprasJogo.Update(cj);
            jogo_presenter.EditarJogo(jogo);
            db.SaveChanges();
        }
        public List<Compras> BuscarCompras()
        {
            return db.Compras.ToList();
        }


        public List<Fornecedor> ObterFornecedores()
        {
            return db.Fornecedor.ToList();
        }

        public List<Jogo> ObterJogos()
        {
            return db.Jogo.ToList();
        }

        public Compras ObterCompraPorId(int id_compra)
        {
            return db.Compras.FirstOrDefault(c => c.Id == id_compra);
        }

        public Fornecedor ObterFornecedorPorId(int id_fornecedor)
        {
            return db.Fornecedor.FirstOrDefault(f => f.Id == id_fornecedor);
        }

        public Jogo ObterJogoPorId(int id_jogo)
        {
            return db.Jogo.FirstOrDefault(j => j.Id == id_jogo);
        }

        public ComprasJogo ObterCompraJogoPorId(int id_compra)
        {
            return db.ComprasJogo.FirstOrDefault(cj => cj.IdCompra == id_compra);
        }
    }
}
