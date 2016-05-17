using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class Program
  {
    static void Main(string[] args)
    {
      string Access = null;

      Console.Write("Введите код приложения: ");
      Access = Console.ReadLine();

      DocumentWorker dw = null;

      switch (Access)
      {
        case "Pro":
          dw = new DocumentWorkerPro();
          break;
        case "Expert":
          dw = new ExpertDocumentWorker();
          break;
        default:
          dw = new DocumentWorker();
          break;
      }

      dw.OpenDocument();
      dw.EditDocument();
      dw.SaveDocument();

      Console.ReadKey();
    }
  }
}
