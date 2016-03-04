using System;

namespace CorsoDiProgrammazione
{
    class Program
    {
        static void Main(string[] args)
        {
            var corso = new Corso();

            string titolo;
            if (string.IsNullOrEmpty(args[0]))
                titolo = Console.ReadLine();
            else
                titolo = args[0];

            // Più sinteticamente potremmo scrivere:
            //var titolo = string.IsNullOrEmpty(args[0]) ? Console.ReadLine() : args[0];

            corso.AssegnaTitolo(titolo);

            Console.WriteLine(corso.Titolo);
            Console.ReadLine();

            corso.Dispose();
        }
    }
}
