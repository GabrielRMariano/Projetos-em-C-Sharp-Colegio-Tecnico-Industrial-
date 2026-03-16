using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_final.Classes
{
    [Table("fornecedor_compras")]
    public class FornecedorCompras
    {
        private int quantidade;
        private double valor_pago;

        [Column("quantidade")]
        public int Quantidade { get => quantidade; set => quantidade = value; }
        [Column("valor_pago")]
        public double Valor_pago { get => valor_pago; set => valor_pago = value; }
        [ForeignKey("fk_id_fornecedor")]
        public virtual Fornecedor Fornecedor { get; set; }
        [ForeignKey("fk_id_compra")]
        public virtual Compras Compra {  get; set; }

        public FornecedorCompras()
        {
            Compra = new Compras();
            Fornecedor = new Fornecedor();    
        }
    }
}
