using System;
using System.Threading;

namespace Cronometro
{
    class Contador
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Cronometro Stop Watch");
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minuto => 1m = 1 minuto");
            Console.WriteLine("0 = sair");

            string option = Console.ReadLine().ToLower();
            char type = char.Parse(option.Substring(option.Length -1, 1));
            int time = int.Parse(option.Substring(0, option.Length -1));

            int multiplier = 1;

            if(type == 'm') multiplier = 60;

            if(time == 0) System.Environment.Exit(0);

            Prepare(time * multiplier);
        }

        static void Prepare(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(1000);

            Start(time);
        }
        static void Start(int time)
        {
            int current = 0;

            while(current != time )
            {
                Console.Clear();
                current++;
                Console.WriteLine(current);
                Thread.Sleep(1000);

            }

            Console.WriteLine();
            Console.WriteLine($"Stop Watch contou até {current}");
            Thread.Sleep(500);
            Console.WriteLine("Finalizando Stop Watch");
            Thread.Sleep(2500);
            Menu();

        }
    }
}