using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Data
{
    public class Validacao
    {
        public static string ValidarStringEmBranco()
        {
            string dado = String.Empty;
            while (true)
            {
                dado = Console.ReadLine();
                if (dado.Trim() == "")
                {
                    Console.WriteLine("valor invalido");
                }
                else
                {
                    return dado;
                }
            }
        }


        public static int ValidarInteiro()
        {
            do
            {
                try
                {
                    int dado = Convert.ToInt32(Console.ReadLine());
                    return dado;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor Invalido");
                }
            } while (true);
        }
    }
}
