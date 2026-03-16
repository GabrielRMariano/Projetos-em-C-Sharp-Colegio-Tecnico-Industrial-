using System.Collections.Generic;
using System.Linq;
using proj_final.Classes;

namespace proj_final.Presenters
{
    public class FornecedorPresenter
    {
        private Contexto db;

        public FornecedorPresenter(Contexto db)
        {
            this.db = db;
        }

        public List<Fornecedor> BuscarFornecedores(string busca)
        {
            return db.Fornecedor
                .Where(f => f.Nome.ToUpper().Contains(busca.ToUpper()))
                .ToList();
        }

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            db.Fornecedor.Add(fornecedor);
            db.SaveChanges();
        }

        public void EditarFornecedor(Fornecedor fornecedor)
        {
            db.Fornecedor.Update(fornecedor);
            db.SaveChanges();
        }

        public void RemoverFornecedor(Fornecedor fornecedor)
        {
            db.Fornecedor.Remove(fornecedor);
            db.SaveChanges();
        }

        public Fornecedor ObterFornecedorPorId(int idFornecedor)
        {
            return db.Fornecedor.FirstOrDefault(f => f.Id == idFornecedor);
        }

        public bool FornecedorTemJogoAssociado(int id_fornecedor)
        {
            return db.Jogo.Any(j => j.Fornecedor.Id == id_fornecedor);
        }

    }
}
