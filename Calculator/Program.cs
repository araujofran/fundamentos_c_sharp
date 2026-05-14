using System;

namespace Calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Numero:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("O número digitado foi:" + v1 + ". O segundo numero foi de:" + v2 + ".");

            float r_soma = v1 + v2;
            Console.WriteLine("A soma é de :" + r_soma);

            Console.ReadKey();
            Console.WriteLine();
            Menu();
        }
        static void Subtracao()

        {
            Console.Clear();
            Console.WriteLine("Digite um numero:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado dessa subtração é de {v1 - v2}");
            Console.ReadKey();
            Console.WriteLine();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite um numero:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro nome:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado dessa divisão foi de {v1 / v2}");
            Console.ReadKey();
            Console.WriteLine();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite um numero:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um segundo numero:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"A multiplicação entre os dois números é de {v1 * v2}");
            Console.ReadKey();
            Console.WriteLine();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("============================================================");
            Console.WriteLine("=============CALCULADORA INTELIGENTE C#=====================");
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("[1] SOMA");
            Console.WriteLine("[2] SUBTRAÇÃO");
            Console.WriteLine("[3] DIVISÃO");
            Console.WriteLine("[4] MULTIPLICAÇÃO");
            Console.WriteLine("[5] SAIR");
            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine("SELECIONE!!!");
            short resp = short.Parse(Console.ReadLine());
            switch(resp)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
            Console.WriteLine();
            Console.WriteLine("FIM!!!");

        }
    }

}