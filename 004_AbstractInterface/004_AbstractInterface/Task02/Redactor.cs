using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class Redactor
  {
    AbstractHandler handler = null;

    public Redactor(string fileName)
    {
      switch (fileName.Substring(fileName.Length - 4))
      {
        case ".xml":
          handler = new XMLHandler(fileName);
          break;
        case ".txt":
          handler = new TXTHandler(fileName);
          break;
        case ".doc":
          handler = new DOCHandler(fileName);
          break;
        default:
          Console.WriteLine("Формат файла не опознан.");
          break;
      }
    }

    public void Open()
    {
      if (handler != null)
        handler.Open();
    }
    public void Create()
    {
      if (handler != null)
        handler.Create();
    }
    public void Change()
    {
      if (handler != null)
        handler.Change();
    }
    public void Save()
    {
      if (handler != null)
        handler.Save();
    }
  }
}
