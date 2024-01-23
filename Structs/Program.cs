using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse gamer", 35.99,EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);
            mouse.Id = 44;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine(manutencaoEletrica.Id);
            Console.WriteLine(manutencaoEletrica.Name);
            Console.WriteLine(manutencaoEletrica.Price);
            Console.WriteLine((int)manutencaoEletrica.Type); //Conversão explicita
            Console.WriteLine(manutencaoEletrica.Type);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PrinceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType {
        Product = 1,
        Service = 2
    }
}