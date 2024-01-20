using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentário de linha.
            /*
                Comentário multi linhas.
            */

            //Constante em C#.
            const int CONSTANTE_ALGO = 25;
            Console.WriteLine(CONSTANTE_ALGO);


            //Números inteiros podem ser representados por int / uint /short /ushort e long / ulong.
            short valor1 = -20; //valor mínimo de -32.768 e um valor máximo de 32.767.
            int valor2 = 25; //valor mínimo de -2.147.483.648 e um valor máximo de 2.147.483.647.
            long valor3 = 2000000000; //valor mínimo de -9.223.372.036.854.775.808 e um valor máximo de 9.223.372.036.854.775.807.
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);


            var texto = "Testando"; //Varíavel em c#.
            Console.WriteLine(texto);

            //Números reais podem ser representados por float / double / decimal.
            float altura = 1.76f; // Números reais FLOAT, sempre com f no final do número.
            double d = 1.7976931348623157e+308; // Números reais double, nao precisa de letra no final.
            decimal dec = 12345.6789012345m; // Números reais DECIMAL, sempre com m no final do número.
            Console.WriteLine(altura);


            //Boolean True ou False.
            bool usuarioCadastrado = false;
            bool pagamentoRecebido = true;
            var usuarioExpirado = false;


            //Char serve para armazenar apenas um caractere, chamado de Unicode. Sempre usar aspas simples.
            char letra = 'A';
            char numero = '5';


            //String serve para armazenar uma cadeia de caracteres.
            string frase = "Hello World";
            var documento = "12345678";


            //VAR - Usar depois de ter facilidade com os tipos.
            var idade = 24; // Será do tipo int.
            var nome = "maicon"; //Será do tipo string.

            
            //Object - Tipo genérico que recebe qualquer valor ou objeto. Evite usar
            object idade2 = 25; //Será do tipo object
            object quantidade; //Será do tipo object
            quantidade = 30;
            object nome1 = "maicon"; //Será do tipo object


            //NULL - Valores nulos  |  usa-se interrogação na frente
            int? numeros = null;
            Console.WriteLine(numeros);

            int? idades = 0;
            Console.WriteLine(idades);
            idades = null;
            Console.WriteLine(idades);
            idades = 24;
            Console.WriteLine(idades);


            //Conversão Implícita - Trasnformando um dado do tipo x para tipo y.
            //A conversão ocorre pois um número real pode receber um número inteiro, porém ao ccontrario nao funciona
            float valor = 25.8f;
            int outro = 25;
            outro = valor;//Não funciona
            valor = outro;//Funciona - Conversão implícita


            //Conversão Explícita - Ocorre quando os tipos não são compatíveis.
            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro;
            

            //Parse - Metodo presente em todo tipo primitivo - Usado para tentar converter um caractere ou string para um tipo qualquer, caso haja alguma incompatibilidade, gera um erro.
            int inteiro2 = int.Parse("100");

            int valor5 = 100;
            float real = 25.5f;
            


            //Convert - Similiar ao parse, porém permite tentar converter vários tipos de valor (não apenas string), Devemos informar o tipo na chamada de conversão.
            int inteiro3 = Convert.ToInt32("100");
        } 
    }
}