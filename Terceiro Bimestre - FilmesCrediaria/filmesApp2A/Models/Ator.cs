using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp2A.Models
{
    [Table("atores")]
    public class Ator
    {
        private int id;
        private string nome;

        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }
        public virtual List<Filme> Filmes { get; set; }
        [ForeignKey("pais_id")]
        public virtual Pais Nacionalidade { get; set; }

        public Ator()
        {
            nome = "";
            Filmes = new List<Filme>();
            Nacionalidade = new Pais();
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
