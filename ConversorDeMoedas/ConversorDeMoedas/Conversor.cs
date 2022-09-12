namespace ConversorDeMoedas;

public class Conversor
{
   public int Tipo;

   public void Valor(double valor)
   {
      switch (Tipo)
      {
         case 1:
            Console.Write("Quanto está o Dólar? ");
            break;
         case 2:
            Console.Write("Quanto está o Euro? ");
            break;
         case 3:
            Console.Write("Quanto está o Libras? ");
            break;
      }
   }
}