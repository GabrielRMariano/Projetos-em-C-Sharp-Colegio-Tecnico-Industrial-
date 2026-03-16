using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_final.Classes
{
    [Table("jogo")]
    public class Jogo
    {
        private int id_produto;
        private string genero;
        private string titulo;
        private double preco;
        private DateOnly data_lancamento;
        private int qtde_estoque;
        private List<ComprasJogo> cj;

        [Column("id_produto")]
        public int Id { get => id_produto; set => id_produto = value; }

        [Column("titulo")]
        public string Titulo { get => titulo; set => titulo = value; }

        [Column("genero")]
        public string Genero { get => genero; set => genero = value; }

        [Column("preco")]
        public double Preco { get => preco; set => preco = value; }

        [Column("data_lancamento")]
        public DateOnly Data_lancamento { get => data_lancamento; set => data_lancamento = value; }

        [Column("qtde_estoque")] 
        public int Qtde_estoque { get => qtde_estoque; set => qtde_estoque = value; }

        [ForeignKey("fk_id_fornecedor")]
        public virtual Fornecedor Fornecedor { get; set; }

        public virtual List<ComprasJogo> Cj { get => cj; set => cj = value; }

        public Jogo()
        {
            data_lancamento = new DateOnly();
            Fornecedor = new Fornecedor();
        }
    }
}
