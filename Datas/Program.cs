using System;
using System.Data;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /*
                //Apenas criando uma estrutura que ira vir com valores padrões
                var data2 = new DateTime();
                Console.WriteLine(data2);

                //pegando a data e hora atual
                var data = DateTime.Now;
                Console.WriteLine(data);

                //Criado um DateTime personalizado com data e hora
                var data = new DateTime(2024, 01, 26, 15, 40, 36);
                Console.WriteLine(data);
                Console.WriteLine(data.Year);
                Console.WriteLine(data.Month);
                Console.WriteLine(data.Day);
                Console.WriteLine(data.DayOfWeek);
                Console.WriteLine(data.Hour);
            */

            var data = DateTime.Now;

            
            Console.WriteLine(data);
        }
    }
}