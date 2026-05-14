using System;

namespace Calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o Primeiro Numero:");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite um segundo valor:");
            float v2 = float.Parse(Console.ReadLine());


            Console.WriteLine("O número digitado foi:" + v1 + ". O segundo numero foi de:" + v2 + ".");

            float r_soma = v1 + v2;
            Console.WriteLine("A soma é de :" + r_soma);

            

        }
    }

}