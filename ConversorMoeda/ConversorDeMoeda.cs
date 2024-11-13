namespace ConversorMoeda
{
    internal class ConversorDeMoeda
    {
        public static double lof = 6.0;
        public static double DolarParaReal(double quantia, double cotacao)  {
            double total = quantia * cotacao;
            return total + total * lof / 100.0;
        }
    }
}
