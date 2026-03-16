    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_final.Classes
{
    [Table("fornecedor")]
    public class Fornecedor
    {
        private int id_fornecedor;
        private string nome;

        [Column("id_fornecedor")]
        public int Id { get => id_fornecedor; set => id_fornecedor = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }

        public override string ToString()
        {
            return Nome;
        }

    }
}
