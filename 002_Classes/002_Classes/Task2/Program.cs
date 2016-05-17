using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
  class Program
  {
    static void Main(string[] args)
    {
      double value;
      Converter conv = new Converter(5, 10, 3);
      
      Console.Write("Конвертация UAH в USD\nUAH: ");
      value = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("USD: {0}", conv.FromUah(value, Converter.fcurrency.usd));

      Console.Write("Конвертация USD в UAH\nUSD: ");
      value = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("UAH: {0}", conv.ToUah(value, Converter.fcurrency.usd));

      Console.ReadKey();
    }
  }
}
