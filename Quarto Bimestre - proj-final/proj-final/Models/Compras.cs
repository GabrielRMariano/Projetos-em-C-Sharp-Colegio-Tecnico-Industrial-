using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proj_final.Classes
{
    [Table("compras")]
    public class Compras
    {
        private int id_compra;
        private DateOnly data_compra;

        [Column("id_compra")]
        public int Id { get => id_compra; set => id_compra = value; }
        [Column("data_compra")]
        public DateOnly Data_compra { get => data_compra; set => data_compra = value; }
        [ForeignKey("fk_id_fornecedor")]
        public virtual Fornecedor Fornecedor { get; set; }

        public Compras(){
            data_compra = new DateOnly();
            Fornecedor = new Fornecedor();

        }
    }
}
