using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_final.Classes
{
    [Table("venda_jogo")]
    public class VendaJogo
    {
        private int quantidade;
        private double valor_pago;

        [Column("quantidade")]
        public int Quantidade { get => quantidade; set => quantidade = value; }

        [Column("valor_pago")]
        public double ValorPago { get => valor_pago; set => valor_pago = value; }

        [ForeignKey("IdVenda")]
        public virtual Venda Venda { get; set; }

        [Column("fk_id_venda")]
        public int IdVenda { get; set; }

        [ForeignKey("IdProduto")]
        public virtual Jogo Produto { get; set; }

        [Column("fk_id_produto")]
        public int IdProduto { get; set; }

        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }

        [Column("fk_id_funcionario")]
        public int IdFuncionario { get; set; }

        public VendaJogo()
        {
        }
    }
}
