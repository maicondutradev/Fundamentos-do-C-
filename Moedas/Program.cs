using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m;

            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.WriteLine(Math.Round(valor));//Arredondando um valor
            Console.WriteLine(Math.Ceiling(valor));//Arredondando um valor para cima
            Console.WriteLine(Math.Floor(valor));//Arredondando um valor para baixo
        }
    }
}