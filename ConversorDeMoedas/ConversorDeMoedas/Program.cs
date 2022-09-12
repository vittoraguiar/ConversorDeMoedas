using System;

namespace ConversorDeMoedas
{
    class Program
    {
        public static void Main(string[] args)
        {
            Conversor conv = new Conversor();
            
            Console.WriteLine("Qual moeda você deseja comprar?");
            Console.WriteLine("1 - Dolar\n2 - Euro\n3 - Libras");
            conv.Tipo = int.Parse(Console.ReadLine()!);
            Console.WriteLine(conv.Valor);
            
            
        }
    }
}