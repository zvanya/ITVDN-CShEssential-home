using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  abstract class AbstractHandler
  {
    protected string fileName;

    public AbstractHandler(string fileName)
    {
      this.fileName = fileName;
    }

    abstract public void Open();
    abstract public void Create();
    abstract public void Change();
    abstract public void Save();
  }

  class XMLHandler : AbstractHandler
  {
    public XMLHandler(string fileName) : base (fileName)
    { }

    public override void Open()
    {
      Console.WriteLine("XML {0} Open.", fileName);
    }
    public override void Create()
    {
      Console.WriteLine("XML {0} Create.", fileName);
    }
    public override void Change()
    {
      Console.WriteLine("XML {0} Change.", fileName);
    }
    public override void Save()
    {
      Console.WriteLine("XML {0} Save.", fileName);
    }
  }

  class TXTHandler : AbstractHandler
  {
    public TXTHandler(string fileName) : base (fileName)
    { }

    public override void Open()
    {
      Console.WriteLine("TXT {0} Open.", fileName);
    }
    public override void Create()
    {
      Console.WriteLine("TXT {0} Create.", fileName);
    }
    public override void Change()
    {
      Console.WriteLine("TXT {0} Change.", fileName);
    }
    public override void Save()
    {
      Console.WriteLine("TXT {0} Save.", fileName);
    }
  }

  class DOCHandler : AbstractHandler
  {
    public DOCHandler(string fileName) : base (fileName)
    { }

    public override void Open()
    {
      Console.WriteLine("DOC {0} Open.", fileName);
    }
    public override void Create()
    {
      Console.WriteLine("DOC {0} Create.", fileName);
    }
    public override void Change()
    {
      Console.WriteLine("DOC {0} Change.", fileName);
    }
    public override void Save()
    {
      Console.WriteLine("DOC {0} Save.", fileName);
    }
  }
}
