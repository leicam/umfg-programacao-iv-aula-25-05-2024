using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.Delegates
{
    internal delegate int CalculadoraEvent(int valorUm, int valorDois);

    internal static class DelegadoComposto
    {
        internal static void Executar()
        {
            CalculadoraEvent calculadoraUm = Multiplicar;
            CalculadoraEvent calculadoraDois = Dividir;
            CalculadoraEvent calculadoraTres = calculadoraUm + calculadoraDois;

            Console.WriteLine($"Multiplicacao: {calculadoraUm(10, 2)}");
            Console.WriteLine($"Divisao: {calculadoraDois(10, 2)}");
            Console.WriteLine($"{calculadoraTres.Method}: {calculadoraTres(10, 2)}");

            calculadoraTres -= calculadoraDois;
            //calculadoraTres -= calculadoraUm;
            Console.WriteLine($"{calculadoraTres.Method}: {calculadoraTres(10, 2)}");
        }

        private static int Multiplicar(int valorUm, int valorDois)
            => valorUm * valorDois;

        private static int Dividir(int valorUm, int valorDois)
            => valorUm / valorDois;
    }
}
