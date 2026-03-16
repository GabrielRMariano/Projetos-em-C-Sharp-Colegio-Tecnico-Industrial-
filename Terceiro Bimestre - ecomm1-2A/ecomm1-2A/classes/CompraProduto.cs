using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomm1_2A.classes
{
    [Table("compra_produto")]
    public class CompraProduto
    {

        private double valor_unitario;
        private int quantidade;

        [Column("valor_unitario")]
        public double Valor_unitario {  get=> valor_unitario; set => valor_unitario = value; }
        [Column("quantidade")]
        public int Quantidade { get => quantidade; set => quantidade = value; }
        [ForeignKey("IdProduto")]
        public virtual Produto Produto { get; set; }
        [Column("fk_id_produto")]
        public int IdProduto { get; set; }  
        [ForeignKey("IdCompra")]
        public virtual Compra Compra { get; set; }
        [Column("fk_id_compra")]
        public int IdCompra { get; set; }

        public CompraProduto() {
            Produto = new Produto();
            Compra = new Compra();    
        }
    }
}
