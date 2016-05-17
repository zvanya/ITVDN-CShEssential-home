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
      double side1 = 0;
      double side2 = 0;

      Console.Write("Введите длины сторон прямоугольника.\nСторона 1: ");
      try
      {
        side1 = double.Parse(Console.ReadLine());
      }
      catch (Exception ex)
      {
        side1 = 0;
        Console.WriteLine("Некорректное значение. Сторона 1: {0}", side1);
      }

      Console.Write("Сторона 2: ");
      try
      {
        side2 = double.Parse(Console.ReadLine());
      }
      catch (Exception ex)
      {
        side2 = 0;
        Console.WriteLine("Некорректное значение. Сторона 2: {0}", side2);
      }

      Rectangle rec1 = new Rectangle(side1, side2);

      Console.WriteLine("Площадь прямоугольника: {0}", rec1.Area);
      Console.WriteLine("Периметр прямоугольника: {0}", rec1.Perimeter);

      Console.ReadKey();
    }
  }
}
