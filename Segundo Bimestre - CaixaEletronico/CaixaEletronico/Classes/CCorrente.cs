using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Classes
{
    public class CCorrente : Conta
    {
        public bool especial;

        public CCorrente() : base()
        {
            this.saldo = 0;
            this.status = true;
            transacoes = new List<Transacao>();
        }

        public CCorrente(string numero, double limite) : base(numero)
        {
            this.numero = numero;
            this.limite = limite;
        }

        public bool Especial
        {
            get => this.especial;
        }
    }
}

