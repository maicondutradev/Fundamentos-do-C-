using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ComparacaoStrings();
        }

        static void GuidExemplo()
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("a55295ce-0417-40f1-be1c-0d7200785af5");

            Console.WriteLine(id.ToString().Substring(0, 8));
        }

        static void InterpolaçãoStrings()
        {

            /*
                //Primeira forma de concatenação
                var price = 10.2;
                var texto = "O preço do produto é " + price + " apenas na promoção!";
                Console.WriteLine(texto);
            */

            /*
                //Segunda forma de concatenação
                var price = 10.2;
                var texto = string.Format("O preço do produto é {0} apenas na promoção!", price);
                Console.WriteLine(texto);
            */

            //Terceira forma de concatenação - Pode usar @ depois do $ para escrever multiplas linhas de texto.
            var price = 10.2;
            var texto = $"O preço do produto é {price} apenas na promoção!";
            Console.WriteLine(texto);

        }

        static void ComparacaoStrings()
        {
            /*
                var texto = "Este texto é um teste";
                Console.WriteLine(texto.CompareTo("Testando"));

                Console.WriteLine(texto.CompareTo("testando"));

                Console.WriteLine(texto.Contains("texto"));

                Console.WriteLine(texto.Contains("Texto"));

                Console.WriteLine(texto.Contains("Texto", StringComparison.OrdinalIgnoreCase));//Ignorando o case sensitive

                Console.WriteLine(texto.StartsWith("Este"));//Verifica se a palavra inicial é a palavra escolhida

                Console.WriteLine(texto.EndsWith("teste"));//Verifica se a palavra final é a palavra escolhida

                Console.WriteLine(texto.Equals("Este texto é um teste"));//Verifica se o texto escolhido é igual ao texto de comparação.
            */

            var texto = "Esse texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));//Descobrir em qual indice(index) está o valor escolhido


        }
    }
}
