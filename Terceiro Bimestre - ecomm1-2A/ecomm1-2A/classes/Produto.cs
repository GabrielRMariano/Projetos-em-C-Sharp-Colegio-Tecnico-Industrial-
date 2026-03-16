using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomm1_2A.classes
{
    [Table("produto")]
    public class Produto
    {
        private int id_produto;
        private string nome;
        private string descricao;
        private double valor_unitario;
        private string tipo_produto;
        private bool excluido;
        private DateOnly? data_exclusao;
        private int qtde_estoque;
        private List<CompraProduto> compras;
        //lista compraproduto

        
        [Column("id_produto")]
        public int Id { get => id_produto; set => id_produto = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }
        [Column("descricao")]
        public string Descricao { get => descricao; set => descricao = value; }
        [Column("valor_unitario")]
        public double Valor_unitario {  get => valor_unitario; set => valor_unitario = value;}
        [Column("tipo_produto")]
        public string Tipo_produto { get => tipo_produto; set => tipo_produto = value;}
        [Column("excluido")]
        public bool Excluido { get => excluido; set => excluido = value;}
        [Column("data_exclusao")]
        public DateOnly? Data_exclusao { get => data_exclusao; set => data_exclusao = value; }
        [Column("qtde_estoque")]
        public int Qtde_estoque {  get => qtde_estoque; set => qtde_estoque = value;}

        public virtual List<CompraProduto> Compras { get => compras; set => compras = value; }


        public Produto()
        {
            nome = "";
            descricao = "";
            excluido = false;
            data_exclusao = new DateOnly();
        }
    }
}
