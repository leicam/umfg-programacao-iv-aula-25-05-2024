using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.Delegates
{
    internal delegate int Subtrair(int valorUm, int valorDois);

    internal static class DelegadoBasico
    {
        internal static void Executar()
        {
            Subtrair subtrairExUm = SubtrairExUm;
            Subtrair subtrairExDois = SubtrairExDois;

            Console.WriteLine($"Subtrair ex um: {subtrairExUm(33, 11)}");
            Console.WriteLine($"Subtrair ex dois: {subtrairExDois(33, 11)}");

            var calculadora = new Calculadora();
            subtrairExDois = calculadora.Multiplicar;
            Console.WriteLine($"Multiplicar ex tres: {subtrairExDois(33, 11)}");
        }

        private static int SubtrairExUm(int valorUm, int valorDois)
        {
            return valorUm - valorDois;
        }

        private static int SubtrairExDois(int valorUm, int valorDois)
        {
            return valorDois - valorUm;
        }
    }
}
