using System;
using System.Runtime.CompilerServices;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Structs();
        }

        public static void Arrays()
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 }; //Montagem de um Array(lista)

            meuArray[0] = 12; //Adicionando um valor dentro do array escolhido

            //Percorrendo todos os itens do nosso array usando for.
            for (var item = 0; item < meuArray.Length; item++)
            {
                Console.WriteLine(meuArray[item]);
            }

            //Percorrendo todos os itens do nosso array usando foreach.RECOMENDADO
            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);
            Console.WriteLine(meuArray.Length); //Para saber a quantidade de itens no array


            var meuArrayString = new string[2] { "Maicon", "Mirela" };
            Console.WriteLine(meuArrayString[0]);
            Console.WriteLine(meuArrayString[1]);
        }

        public static void Structs()
        {
            //Utilizando um Foreach com struct
            Console.Clear();
            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2345, Nome = "Maicon" };
            funcionarios[1] = new Funcionario() { Id = 5637, Nome = "Mirela" };
            funcionarios[2] = new Funcionario() { Id = 2853, Nome = "Izabel" };
            funcionarios[3] = new Funcionario() { Id = 9764, Nome = "Mario" };
            funcionarios[4] = new Funcionario() { Id = 1254, Nome = "João" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }
        }

        public struct Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
