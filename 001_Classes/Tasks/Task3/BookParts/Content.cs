using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
  class Content
  {
    string content_text;
    public string Content_text
    {
      private get
      {
        if (content_text != null)
          return content_text;
        else
          return "Текст книги отсутствует.";
      }
      set
      {
        this.content_text = value;
      }
    }

    public void Show()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Текст книги: {0}", this.Content_text);
      Console.ForegroundColor = ConsoleColor.Gray;
    }
  }
}
