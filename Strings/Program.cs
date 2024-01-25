using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ManipulandoStrings();
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

            var texto = "Este texto é um teste";
            Console.WriteLine(texto.CompareTo("Testando"));

            Console.WriteLine(texto.CompareTo("testando"));

            Console.WriteLine(texto.Contains("texto"));

            Console.WriteLine(texto.Contains("Texto"));

            Console.WriteLine(texto.Contains("Texto", StringComparison.OrdinalIgnoreCase));//Ignorando o case sensitive

            Console.WriteLine(texto.StartsWith("Este"));//Verifica se a palavra inicial é a palavra escolhida

            Console.WriteLine(texto.EndsWith("teste"));//Verifica se a palavra final é a palavra escolhida

            Console.WriteLine(texto.Equals("Este texto é um teste"));//Verifica se o texto escolhido é igual ao texto de comparação.


            var texto2 = "Esse texto é um teste";
            Console.WriteLine(texto2.IndexOf("é"));//Descobrir em qual indice(index) está o valor escolhido

            Console.WriteLine(texto2.LastIndexOf("s"));//Descobre em qual indice(index) esse valor apareceu por ultimo

            Console.WriteLine(texto2.ToLower());//Convertendo toda a string para minuscula

            Console.WriteLine(texto2.ToUpper());//Convertendo toda a string para maiuscula

            Console.WriteLine(texto2.Insert(5, "AQUI "));//Inserindo um valor no local escolhido, index 5 = AQUI

            Console.WriteLine(texto2.Remove(5, 5));//Remove a partir do index escolhido e os proximos valores até o numero escolhido.

            Console.WriteLine(texto2.Length);//Diz a quantidade de itens na string


        }

        static void ManipulandoStrings()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Replace("Este", "Isto"));//Troca a string, passando o valor que deseja trocar e a sua troca - Segue o case sensitive
        }

    }
}
