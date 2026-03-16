using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_final.Classes
{
    [Table("funcionario")]
    public class Funcionario
    {
        private int id_funcionario;
        private string nome;
        private string senha;
        private bool admin;
        private string email;

        [Column("id_funcionario")]
        public int Id {  get => id_funcionario; set => id_funcionario = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }
        [Column ("email")]
        public string Email { get => email; set => email = value; }
        [Column("admin")]
        public bool Admin { get => admin; set => admin = value; }
        [Column("senha")]
        public string Senha { get => senha; set => senha = value; }

        public Funcionario()
        {
            nome = "";
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
