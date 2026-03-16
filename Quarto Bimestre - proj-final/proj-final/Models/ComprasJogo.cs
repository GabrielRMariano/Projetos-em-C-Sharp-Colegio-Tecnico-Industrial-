using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_final.Classes
{
    [Table("compra_jogo")]
    public class ComprasJogo
    {
        private int quantidade;
        private double valor_pago;

        [Column("quantidade")]
        public int Quantidade { get => quantidade; set => quantidade = value; }

        [Column("valor_pago")]
        public double ValorPago { get => valor_pago; set => valor_pago = value; }

        [ForeignKey("IdCompra")]
        public virtual Compras Compra { get; set; }

        [Column("fk_id_compra")]
        public int IdCompra { get; set; }

        [ForeignKey("IdProduto")]
        public virtual Jogo Produto { get; set; }

        [Column("fk_id_produto")]
        public int IdProduto { get; set; }

        [ForeignKey("IdFornecedor")]
        public virtual Fornecedor Fornecedor { get; set; }

        [Column("fk_id_fornecedor")]
        public int IdFornecedor { get; set; }

        public ComprasJogo()
        {
        }
    }
}
