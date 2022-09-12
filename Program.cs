using System;

namespace ComprarDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaração da moeda que o usuário irá comprar */
            Console.WriteLine("Tabela:\n1 - Dólar\n2 - Euro\n3 - Libra");
            Console.Write("O que você deseja comprar: ");
            int moeda = int.Parse(Console.ReadLine()!);
            ConversorDeMoedas.Moeda(moeda);
            
            /* Declaração da quantia que o usuário irá comprar */
            Console.Write("Quanto você deseja comprar? ");
            double quantia = double.Parse(Console.ReadLine()!);
            
            /* Impressão do valor a ser pago */
            Console.WriteLine("Valor a ser pago: " + ConversorDeMoedas.Conversor(quantia).ToString("C"));
        }
    }
}