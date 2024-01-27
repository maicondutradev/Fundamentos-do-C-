using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 }; //Montagem de um Array(lista)

            meuArray[0] = 12; //Adicionando um valor dentro do array escolhido

            //Console.WriteLine(meuArray[0]);
            //Console.WriteLine(meuArray[1]);
            //Console.WriteLine(meuArray[2]);
            //Console.WriteLine(meuArray[3]);
            //Console.WriteLine(meuArray[4]);
            Console.WriteLine(meuArray.Length);


            var meuArrayString = new string[2] { "Maicon", "Mirela" };
            Console.WriteLine(meuArrayString[0]);
            Console.WriteLine(meuArrayString[1]);
        }
    }
}
