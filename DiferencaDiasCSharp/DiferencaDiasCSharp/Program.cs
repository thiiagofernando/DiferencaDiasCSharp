using System;
using System.Globalization;

namespace DiferencaDiasCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaDias();
        }

        public static void CalculaDias()
        {
            CultureInfo cult = new CultureInfo("pt-BR");
            DateTime PrimeiraData = DateTime.Now;
            DateTime SegundaData = DateTime.Now.AddDays(7);

            Console.WriteLine("Primeira Data: " + PrimeiraData.ToString("dd/MM/yyyy", cult));
            Console.WriteLine("Segunda Data: " + SegundaData.ToString("dd/MM/yyyy", cult));
            Console.WriteLine("Diferença de Dias: " + (SegundaData - PrimeiraData).Days);
            Console.ReadKey();
        }
    }
}
