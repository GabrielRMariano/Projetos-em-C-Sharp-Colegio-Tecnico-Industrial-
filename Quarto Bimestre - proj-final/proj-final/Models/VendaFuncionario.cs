using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_final.Classes
{
    [Table("venda_funcionario")]
    public class VendaFuncionario
    {
        private bool venda_concluida;

        [Column("venda_concluida")]
        public bool Venda_concluida {  get => venda_concluida; set => venda_concluida = value; }
        [Column("fk_id_venda")]
        public virtual Venda Venda { get; set; }
        [Column("fk_id_funcionario")]
        public virtual Funcionario Funcionario { get; set; }

        public VendaFuncionario() 
        {
            Venda = new Venda();
            Funcionario = new Funcionario();
        }
    }
}
