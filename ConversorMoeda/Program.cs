using ConversorMoeda;
using System;
using System.Globalization;

Console.Write("Qual é a cotação do dólar? \n");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos Dólares você vai comprar:\n");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));