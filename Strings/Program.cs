using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            GuidExemplo();
        }

        static void GuidExemplo()
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("a55295ce-0417-40f1-be1c-0d7200785af5");

            Console.WriteLine(id.ToString().Substring(0, 8));
        }
    }
}
