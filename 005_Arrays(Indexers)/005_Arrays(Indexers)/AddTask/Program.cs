﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary dictionary = new Dictionary();

      Console.WriteLine(dictionary["книга"]);
      Console.WriteLine(dictionary["дом"]);
      Console.WriteLine(dictionary["ручка"]);
      Console.WriteLine(dictionary["стол"]);
      Console.WriteLine(dictionary["карандаш"]);
      Console.WriteLine(dictionary["яблоко"]);
      Console.WriteLine(dictionary["sun","en"]);

      Console.WriteLine(new string('-', 20));

      for (int i = 0; i < 6; i++)
      {
        Console.WriteLine(dictionary[i]);
      }

      // Delay.
      Console.ReadKey();
    }
  }
}
