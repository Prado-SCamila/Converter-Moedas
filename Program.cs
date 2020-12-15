using System;
using Converter_Moedas.classes;

namespace Converter_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma moeda:");
            Console.WriteLine("[1] - Dólar");
            Console.WriteLine("[2] - Libra");
            int choice = int.Parse(Console.ReadLine());

            switch(choice){
                case 1:
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Digite uma quantida  em Reais para converter para dólar");
            float valorRS = float.Parse(Console.ReadLine());

            Console.WriteLine("O valor em Dólares é :" +Conversor.RealParaDolar(valorRS));
            

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Digite uma quantia em dólares para converter para Real");
            valorRS = float.Parse(Console.ReadLine());

            Console.WriteLine("O valor em Reais é : "+ Conversor.DolarParaReal(valorRS));
                break;

                case 2:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite uma quantia em Real para converter para Libra");
            valorRS = float.Parse(Console.ReadLine());
             Console.WriteLine("O valor em Reais é : "+ Conversor.RealParaLibra(valorRS));

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Digite uma quantia em Libra para converter para Real");
            valorRS = float.Parse(Console.ReadLine());
            Console.WriteLine("O valor em Reais é : "+ Conversor.LibraParaReal(valorRS));

                break;

            }

           
           
          
        }
    }
}
