using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class ClassRoom
  {
    Random rand = new Random();
    Pupil[] p = new Pupil[4];

    public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
    {
      this.p[0] = p1;
      this.p[1] = p2;
      this.p[2] = p3;
      this.p[3] = p4;
    }

    public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
    {
      this.p[0] = p1;
      this.p[1] = p2;
      this.p[2] = p3;
      this.p[3] = GeneratePupil();
    }

    public ClassRoom(Pupil p1, Pupil p2)
    {
      this.p[0] = p1;
      this.p[1] = p2;
      this.p[2] = GeneratePupil();
      this.p[3] = GeneratePupil();
    }

    Pupil GeneratePupil()
    {
      int r = rand.Next(1, 3);

      switch (r)
      {
        case 1:
          return new ExcelentPupil();
        case 2:
          return new GoodPupil();
        case 3:
          return new BadPupil();
        default:
          return new BadPupil();
      }
    }

    public void ShowInfo()
    {
      foreach (Pupil pupil in p)
      {
        if (pupil != null)
        {
          pupil.Read();
          pupil.Write();
          pupil.Study();
          pupil.Relax();

          Console.WriteLine(new string('-', 30));
        }
      }
    }
  }
}
