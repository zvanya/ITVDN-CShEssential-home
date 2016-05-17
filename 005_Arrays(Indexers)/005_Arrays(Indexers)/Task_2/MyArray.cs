using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
  class MyArray
  {
    int[] a;

    public MyArray(int k)
    {
      a = new int[k];
      Random rand = new Random();

      for (int i = 0; i < k; i++)
      {
        a[i] = rand.Next(20);
      }
    }

    public int Min()
    {
      return a.Min();
    }
    public int Max()
    {
      return a.Max();
    }
    public int Sum()
    {
      return a.Sum();
    }
    public float Average()
    {
      return (float)a.Sum() / a.Length;
    }
    public int Val(int index)
    {
      return a[index];
    }
    public void Odd()
    {
      Console.Write("Нечетные зн-я: ");

      for (int i = 0; i < a.Length; i++)
      {
        if (a[i] % 2 != 0)
        {
          Console.Write("{0} ", a[i]);
        }
      }
    }
  }
}
