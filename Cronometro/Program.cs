using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {

        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            int time = 61;
            int index = 0;
            int currentTime = 0;
            string[] spinner = { "/", "-", "\\", "|" };

            while (currentTime != time)
            {
                Console.Write($"\r{spinner[index]} Tempo: {currentTime}s");

                Thread.Sleep(1000);

                currentTime++;

                index++;

                if (index == spinner.Length)
                    index = 0;


            }
            Console.WriteLine("\nUm minuto! Acabou o Tempo!");
        }
    }
}
