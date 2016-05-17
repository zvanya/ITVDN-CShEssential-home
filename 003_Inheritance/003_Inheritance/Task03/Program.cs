using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Program
  {
    static void Main(string[] args)
    {
      Ship s = new Ship("port1", 500, 34, 345, 5000000, 120, 1975);
      Plane p = new Plane(3, 500, 135, 10, 12000, 900, 1900);

      Console.WriteLine("p.X = {0}", p.X);

      Console.ReadKey();
    }
  }
}
