using System.Collections.Generic;
using System.Linq;
using proj_final.Classes;

namespace proj_final.Presenters
{
    public class FuncionarioPresenter
    {
        private Contexto db;

        public FuncionarioPresenter(Contexto db)
        {
            this.db = db;
        }

        public List<Funcionario> BuscarFuncionarios(string busca)
        {
            return db.Funcionario
                .Where(f => f.Nome.ToUpper().Contains(busca.ToUpper()))
                .ToList();
        }

        

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            db.Funcionario.Add(funcionario);
            db.SaveChanges();
        }

        public void EditarFuncionario(Funcionario funcionario)
        {
            db.Funcionario.Update(funcionario);
            db.SaveChanges();
        }

        public void RemoverFuncionario(Funcionario funcionario)
        {
            db.Funcionario.Remove(funcionario);
            db.SaveChanges();
        }

        public Funcionario ObterFuncionarioPorId(int idFuncionario)
        {
            return db.Funcionario.FirstOrDefault(f => f.Id == idFuncionario);
        }

        public Funcionario ObterFuncionarioPorEmail(string email)
        {
            return db.Funcionario.FirstOrDefault(f => f.Email.ToUpper().Contains(email.ToUpper()));
        }
    }
}