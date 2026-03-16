using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_final.Classes
{
    [Table("venda")]
    public class Venda
    {
        private int id_venda;
        private DateOnly data_venda;

        [Column("id_venda")]
        [Key]
        public int Id_venda { get => id_venda; set => id_venda = value; }
        [Column("data_venda")]
        public DateOnly Data_venda { get => data_venda; set => data_venda = value; }
        [ForeignKey("fk_id_funcionario")]
        public virtual Funcionario Funcionario { get; set; }

        public Venda()
        {
            data_venda = new DateOnly();
            Funcionario = new Funcionario();
        }

    }
}
