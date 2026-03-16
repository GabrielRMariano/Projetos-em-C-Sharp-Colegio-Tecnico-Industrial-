using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp2A.Models
{
    [Table("paises")]
    public class Pais
    {
        private int id;
        private string nome;

        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }
        public virtual List<Ator> Atores { get; set; }
        public virtual List<Filme> Filmes { get; set; }

        public Pais()
        {
            nome = "";
            Atores = new List<Ator>();
            Filmes = new List<Filme>();
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
