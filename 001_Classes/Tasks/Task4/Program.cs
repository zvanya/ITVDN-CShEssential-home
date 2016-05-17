using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
  class Program
  {
    static void Main(string[] args)
    {
      //Point[] p = new Point[4];

      //p[0] = new Point(0, 0, "p1");
      //p[1] = new Point(0, 7, "p2");
      //p[2] = new Point(5, 7, "p3");
      //p[3] = new Point(5, 0, "p4");

      //Figure figure = new Figure(p[0], p[1], p[2], p[3]);


      Figure figure = new Figure(new Point(0, 0, "p1"), new Point(0, 7, "p2"), new Point(5, 7, "p3"), new Point(5, 0, "p4"));

      Console.Write("Периметр фигуры \"{0}\" равен ", figure.Type);
      figure.PerimeterCalculator();

      Console.ReadKey();
    }
  }
}
