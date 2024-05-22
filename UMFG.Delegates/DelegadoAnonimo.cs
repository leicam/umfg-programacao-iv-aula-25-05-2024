using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.Delegates
{
    internal delegate int Somar(int valorUm, int valorDois);

    internal static class DelegadoAnonimo
    {
        internal static void Executar()
        {
            Somar somar = delegate (int valorUm, int valorDois)
            {
                return valorUm + valorDois;
            };

            Console.WriteLine($"Soma: {somar(33, 11)}");
        }
    }
}
