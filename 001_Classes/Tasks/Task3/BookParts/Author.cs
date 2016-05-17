using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
  class Author
  {
    string content;
    public string Content
    {
      private get
      {
        if (content != null)
          return content;
        else
          return "Автор отсутствует.";
      }
      set
      {
        this.content = value;
      }
    }

    public void Show()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Автор: {0}", this.Content);
      Console.ForegroundColor = ConsoleColor.Gray;
    }

  }
}
