namespace ComprarDolar;

public static class ConversorDeMoedas
{
    private static double _ioF = 0.06;
    private static double _valorMoeda;

    /* Definição do valor da moeda */
    public static void Moeda(int moeda)
    {
        switch (moeda)
        {
            case 1:
                Console.Write("\nQual o valor do Dólar? ");
                _valorMoeda = double.Parse(Console.ReadLine()!);
                break;
            case 2:
                Console.Write("\nQual o valor do Euro? ");
                _valorMoeda = double.Parse(Console.ReadLine()!);
                break;
            case 3:
                Console.Write("\nQual o valor da Libra? ");
                _valorMoeda = double.Parse(Console.ReadLine()!);
                break;
        }
    }

    /* Retorno do valor a ser pago */
    public static double Conversor(double quantia)
    {
        double result = quantia * _valorMoeda;
        return result += result * _ioF;
    }
}