﻿using System;

namespace AddTask
{
  class Title : DocumetParts
  {
    public override string Content
    {
      get
      {
        if (content != null)
          return content;
        else
          return "Заголовок отсутствует.";
      }
      set
      {
        content = value;
      }
    }

    public override void Show()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(Content);
      Console.ForegroundColor = ConsoleColor.Gray;
    }
  }
}
