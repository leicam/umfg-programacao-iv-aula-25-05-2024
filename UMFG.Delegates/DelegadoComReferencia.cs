using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.Delegates
{
    internal delegate int CalculadoraComReferencia(int valorUm, ref int valorDois);
    internal static class DelegadoComReferencia
    {
        internal static void Executar()
        {
            CalculadoraComReferencia somarMaisVinte = SomarMaisVinte;
            CalculadoraComReferencia somar = Somar;

            int valorUm = 10;
            int valorDois = 20;

            Console.WriteLine($"Somar: {somar(valorUm, ref valorDois)}");
            Console.WriteLine($"Somar mais vinte: {somarMaisVinte(valorUm, ref valorDois)}");
            Console.WriteLine($"Somar: {somar(valorUm, ref valorDois)}");
        }
        private static int Somar(int valorUm, ref int valorDois)
            => valorUm + valorDois;

        private static int SomarMaisVinte(int valorUm, ref int valorDois)
        {
            var resultado = valorUm + valorDois;
            valorDois += 20;
            return resultado;
        }
    }
}
