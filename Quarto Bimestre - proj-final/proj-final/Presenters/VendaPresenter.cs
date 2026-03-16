using proj_final.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_final.Presenters
{
    internal class VendaPresenter
    {
        private Contexto db;
        private JogoPresenter jogo_presenter;

        public VendaPresenter(Contexto db)
        {
            this.db = db;
            jogo_presenter = new JogoPresenter(db);
        }

        public void ExcluirVenda(Venda venda, VendaJogo vj, Jogo jogo)
        {
            jogo.Qtde_estoque += vj.Quantidade;
            jogo_presenter.EditarJogo(jogo);

            db.VendaJogo.Remove(vj);
            db.Venda.Remove(venda);
            db.SaveChanges();
        }

        public void AdicionarVenda(Venda venda, Jogo jogo, int qtd)
        {
            db.Venda.Add(venda);
            db.SaveChanges();

            jogo.Qtde_estoque -= qtd;
            db.Jogo.Update(jogo);
            db.SaveChanges();

            VendaJogo vj = new VendaJogo();
            vj.IdVenda = venda.Id_venda;
            vj.IdFuncionario = venda.Funcionario.Id;
            vj.Quantidade = qtd;
            vj.ValorPago = qtd * jogo.Preco;
            vj.IdProduto = jogo.Id;
            db.VendaJogo.Add(vj);

            db.SaveChanges();
        }

        public void EditarVenda(Venda venda, VendaJogo vj, Jogo jogo)
        {
            db.Venda.Update(venda);
            db.VendaJogo.Update(vj);
            jogo_presenter.EditarJogo(jogo);
            db.SaveChanges();
        }
        public List<Venda> BuscarVendas()
        {
            return db.Venda.ToList();
        }


        public List<Funcionario> ObterFuncionarios()
        {
            return db.Funcionario.ToList();
        }

        public List<Jogo> ObterJogos()
        {
            return db.Jogo.ToList();
        }

        public Venda ObterVendaPorId(int id_venda)
        {
            return db.Venda.FirstOrDefault(v => v.Id_venda == id_venda);
        }

        public Funcionario ObterFuncionarioPorId(int id_funcionario)
        {
            return db.Funcionario.FirstOrDefault(f => f.Id == id_funcionario);
        }

        public Jogo ObterJogoPorId(int id_jogo)
        {
            return db.Jogo.FirstOrDefault(j => j.Id == id_jogo);
        }

        public VendaJogo ObterVendaJogoPorId(int id_venda)
        {
            return db.VendaJogo.FirstOrDefault(vj => vj.IdVenda == id_venda);
        }
    }
}
