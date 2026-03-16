using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORastroDoCoelho
{
    public class Cripto
    {
        public static string Descriptografar(string texto)
        {
            string novo = "";
            if (texto.StartsWith("c:") && texto.EndsWith(":/#"))
                for (int i = 2; i < texto.Length-3; i++)
                    novo += Char.ConvertFromUtf32((int)texto[i] - 20);

            else
                for (int i = 0; i < texto.Length; i++)
                    novo += Char.ConvertFromUtf32((int)texto[i] - 16);


            return novo;
        }
    }
}
