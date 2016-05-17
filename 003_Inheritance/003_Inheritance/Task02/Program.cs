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
      Pupil p1 = new ExcelentPupil();
      Pupil p2 = new ExcelentPupil();
      Pupil p3 = new GoodPupil();
      Pupil p4 = new BadPupil();

      ClassRoom class1 = new ClassRoom(p1, p4);

      class1.ShowInfo();

      Console.ReadKey();

    }
  }
}
