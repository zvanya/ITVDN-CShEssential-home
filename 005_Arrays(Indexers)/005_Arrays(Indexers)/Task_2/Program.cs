using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
  class Program
  {
    static void Main(string[] args)
    {
      int k = 5;

      MyArray a = new MyArray(k);

      for (int i = 0; i < k; i++)
      {
        Console.WriteLine("a{0} = {1}", i, a.Val(i));
      }

      Console.WriteLine("");
      Console.WriteLine("a.Min = {0}", a.Min());
      Console.WriteLine("a.Max = {0}", a.Max());
      Console.WriteLine("a.Sum = {0}", a.Sum());
      Console.WriteLine("a.Average = {0}", a.Average());

      a.Odd();

      Console.ReadKey();
    }
  }
}
