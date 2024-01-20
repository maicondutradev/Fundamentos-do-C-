using System;
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


//Operadores Aritméticos: Soma => + , Subtração => - , Multiplicação =>  * , Divisão => /
//Em caso de números inteiros se o valor for real, será arrendondado.
int soma = 25 + 22; //47
int subtracao = 25 - 22; //3
int divisao = 25 * 22; //550
int multiplicacao = 22 / 5; //4 - Foi arrendado

int x = 2 + 2 * 2; //6
int y = 2 + (2 * 2); //6 - Mesmo do anterior
int z = (2 + 2) * 2; //8 - Executou a soma primeiro


//Operadores de Atribuição - Utilizamos para atribuir um valor
int a = 0; //Atribuição
a += 5; //x = x + 5;
a -= 1; //x = x - 1;
a *= 10; //x = x * 10;
a /= 2; //x = x / 2;
a++; //Adiciona 1
a--; //Diminui 1

//Operadores de comparação - Podemos comparar qualquer tipo de dado (numeros, strings, bytes) Sempre retorna TRUE ou FALSE
/*
    igual - ==
    Diferente - !=
    Maior que - >
    Menor que - <
    Maior ou igual a - >=
    Menor ou igual a - <=
*/


//Operadores Lógicos - Usado para operações condicionais - Retorna SEMPRE True ou false.
/*
    E - and ' && ' (Deve atender TODAS as condições)
    Ou - or ' || ' (Se atender uma condição já retorna verdadeiro)
    NEGAÇÃO - not ' ! '
*/
int v = 12;
bool entre = (x > 25) && (x < 40); //false
bool ou = (x > 25) || (x < 40); //True
bool negacao = !(x < 25); //false


//Estrutura Condicional: IF / Else / Else if
int idadePessoa = 18;
int maioridade = 21;
int idadeFaculdade = 16;

if (idadePessoa >= maioridade)
{
    Console.WriteLine("Pode dirigir!");
}
else if (idadePessoa >= maioridade && idadePessoa >= idadeFaculdade)
{
    Console.WriteLine("Pode dirigir e ir para a faculdade!");
}
else
{
    Console.WriteLine("Não pode dirigir!");
}


//Estrutura Condicional: Switch - Utilizado quando temos muitas decisões, Executado em cascata, devemos parar manualmente a execução com o comando break, possui uma execução padrão chamada default
int valor10 = 1;
switch (valor10)
{
    case 1: Console.WriteLine("1");
        break;
    case 2: Console.WriteLine("2");
        break;
    case 3: Console.WriteLine("3");
        break;
    default: Console.WriteLine("4"); //Se não for 1,2 ou 3
        break;
}

string nomes = "maicon";
switch (nomes)
{
    case "mirela": Console.WriteLine("errou");
        break;
    case "maicon": Console.WriteLine("acertou");
        break;
    case "izabel": Console.WriteLine("errou");
        break;
    default: Console.WriteLine("errou tudo!"); //Se não for nenhum nome dos que estão nos cases.
        break;
}

//o default nunca vai ser executado pois BOOL só retorna true ou false, porém se usarmos o bool?(tipo nullo), pode ser true, false ou nulo.
bool? condicao = true;
switch (condicao)
{
    case true: Console.WriteLine("Verdadeiro");
        break;
    case false: Console.WriteLine("False");
        break;
    default: Console.WriteLine("Nulo");
        break;
}


//Laço de repetição: FOR - Tradução "para", ou seja, para cada item em um valor... Executa uma determinada ação várias vezes, definido pela palavra for, exige 3 parâmetros CONTADOR CONDIÇÃO INCREMENTO
//Poderia ser int ou qualquer outro no lugar de var
//Conta de 0 a 5
for (var i = 0; i <= 5; i++){ 
    Console.WriteLine(i);
}
//Conta de 1 a 5
for (var i = 1; i <= 5; i++){ 
    Console.WriteLine(i);
}
//Conta de 0 a 4
for (var i = 0; i < 5; i++){ 
    Console.WriteLine(i);
}
//Conta de 5 a 0
for (var i = 5; i >= 0; i--){ 
    Console.WriteLine(i);
}

//Laço de repetição: WHILE
