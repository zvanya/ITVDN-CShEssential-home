using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class Program
  {
    static void Main(string[] args)
    {
      Redactor r = new Redactor("file.xml");

      r.Open();
      r.Change();
      r.Save();

      Console.ReadKey();
    }
  }
}
