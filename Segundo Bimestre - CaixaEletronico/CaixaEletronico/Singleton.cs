using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.Classes;

namespace CaixaEletronico
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        public List<Conta> contas;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
        private Singleton() 
        {
            contas = new List<Conta>()
            {
                new CPoupanca("123"),
                new CCorrente("111", 500)
            };
        }
    }
}
