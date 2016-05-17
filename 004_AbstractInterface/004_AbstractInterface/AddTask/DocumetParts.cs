using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  abstract class DocumetParts
  {
    protected string content;
    public abstract string Content
    {
      get;
      set;
    }

    public abstract void Show();
  }
}
