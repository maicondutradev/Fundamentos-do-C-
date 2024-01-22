using System;

class Program
{
    static void Main(string[] args)
    {
        MeuMetodo();
        string nome = RetornaNome("Maicon", "Fonseca Dutra", 23, 78);
        Console.WriteLine(nome);
        Console.WriteLine(RetornaNome("Mirela", "Taciane dos Santos", 23, 55));
    }
    static void MeuMetodo()
    {
        Console.WriteLine("Meu metodo!");
    }
    static string RetornaNome(
    string nome, 
    string sobrenome, 
    int idade, 
    int peso = 0) //parâmetro opcional
    {
        return nome + " " + sobrenome + " tem " + idade.ToString() + " anos de idade!" + peso;
    }
}