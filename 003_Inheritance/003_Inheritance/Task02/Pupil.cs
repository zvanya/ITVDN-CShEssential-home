using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class Pupil
  {
    public virtual void Study()
    { Console.WriteLine("Study"); }
    public virtual void Read()
    { Console.WriteLine("Read"); }
    public virtual void Write()
    { Console.WriteLine("Write"); }
    public virtual void Relax()
    { Console.WriteLine("Relax"); }
  }

  class ExcelentPupil : Pupil
  {
    public override void Study()
    { Console.WriteLine("Study Excelent!!!"); }
    public override void Read()
    { Console.WriteLine("Read Excelent!!!"); }
    public override void Write()
    { Console.WriteLine("Write Excelent!!!"); }
    public override void Relax()
    { Console.WriteLine("Relax Excelent!!!"); }
  }

  class GoodPupil : Pupil
  {
    public override void Study()
    { Console.WriteLine("Study Good!"); }
    public override void Read()
    { Console.WriteLine("Read Good!"); }
    public override void Write()
    { Console.WriteLine("Write Good!"); }
    public override void Relax()
    { Console.WriteLine("Relax Good!"); }
  }

  class BadPupil : Pupil
  {
    public override void Study()
    { Console.WriteLine("Study Bad."); }
    public override void Read()
    { Console.WriteLine("Read Bad."); }
    public override void Write()
    { Console.WriteLine("Write Bad."); }
    public override void Relax()
    { Console.WriteLine("Relax Bad."); }
  }
}
