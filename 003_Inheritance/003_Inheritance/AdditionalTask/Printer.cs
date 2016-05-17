using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
  class Printer
  {
    protected ConsoleColor color;
    public Printer(ConsoleColor color)
    {
      this.color = color;
    }
    public void Print(string value)
    {
      Console.ForegroundColor = color;
      Console.WriteLine(value);
      color = ConsoleColor.Gray;
    }
  }
}
