using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using proj_final.Classes;

namespace proj_final.Presenters
{
    public class JogoPresenter
    {
        private Contexto db;

        public JogoPresenter(Contexto db)
        {
            this.db = db;
        }

        public List<Jogo> BuscarJogos(string busca)
        {
            return db.Jogo
                .Where(j => j.Titulo.ToUpper().Contains(busca.ToUpper()))
                .ToList();
        }

        public void ExcluirJogo(Jogo jogo)
        {
            db.Jogo.Remove(jogo);
            db.SaveChanges();
        }

        public void AdicionarJogo(Jogo jogo)
        {
            db.Jogo.Add(jogo);
            db.SaveChanges();
        }

        public void EditarJogo(Jogo jogo)
        {
            db.Jogo.Update(jogo);
            db.SaveChanges();
        }

        public Jogo ObterJogoPorId(int id_produto)
        {
            return db.Jogo.FirstOrDefault(j => j.Id == id_produto);
        }

        public List<Jogo> ObterJogosPorFornecedor(int id_fornecedor)
        {
            return db.Jogo
                .Where(j => j.Fornecedor.Id == id_fornecedor)
                .ToList();
        }

        public List<Fornecedor> ObterFornecedores()
        {
            return db.Fornecedor.ToList();
        }

        public Fornecedor ObterFornecedorPorId(int id_fornecedor)
        {
            return db.Fornecedor.FirstOrDefault(f => f.Id == id_fornecedor);
        }

    }
}
