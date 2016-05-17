using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
  class Program
  {
    static void Main(string[] args)
    {
      PrinterDer pr_der1 = new PrinterDer(ConsoleColor.Yellow);
      pr_der1.Print("Class PrinterDer1");

      Printer pr = pr_der1 as Printer;
      pr.Print("Class Printer");

      PrinterDer pr_der2 = new PrinterDer(ConsoleColor.Magenta);
      pr_der2.Print("Class PrinterDer2");
      
      Console.ReadKey();
    }
  }
}
