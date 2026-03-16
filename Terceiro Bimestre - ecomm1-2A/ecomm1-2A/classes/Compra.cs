using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomm1_2A.classes
{
    [Table("compra")]
    public class Compra
    {
        // usuario
        private int id_compra;
        private string status;
        private double? acrescimo_total;
        private string sessao;
        private string id_transacao;
        private DateOnly data;
        private decimal? total;
        private Usuario comprador;

        [Column("id_compra")]
        [Key]
        public int Id { get => id_compra; set => id_compra = value; }
        [Column("status")]
        public string Status { get => status; set => status = value; }
        [Column("acrescimo_total")]
        public double? Acrescimo_total { get => acrescimo_total; set => acrescimo_total = value; }
        [Column("sessao")]
        public string Sessao {  get => sessao; set => sessao = value; }
        [Column("id_transacao")]
        public string Id_transacao { get => id_transacao; set => id_transacao = value;}
        [Column("total")]
        public decimal? Total { get => total; set => total = value; }
        [Column("data")]
        public DateOnly Data { get => data; set => data = value; }

        [ForeignKey("fk_id_usuario")]
        public virtual Usuario Comprador { get => comprador; set => comprador = value; }

        public Compra()
        {
            data = new DateOnly();
            acrescimo_total = 0;
            comprador = new Usuario();
        }
    }
}
