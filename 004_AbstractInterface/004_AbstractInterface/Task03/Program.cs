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
      Player p = new Player("file.mp3");

      IPlayable p1 = p as IPlayable;

      p1.Play();


      Console.ReadKey();
    }
  }
}
