using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
  class Book
  {
    Title title = null;
    Content content = null;
    Author author = null;

    public Book(string title)
    {
      InitializeComponent();
      this.title.Content = title;
    }

    void InitializeComponent()
    {
      title = new Title();
      content = new Content();
      author = new Author();
    }

    public string Content
    {
      set
      {
        content.Content_text = value;
      }
    }

    public string Author
    {
      set
      {
        author.Content = value;
      }
    }

    public void Show()
    {
      title.Show();
      content.Show();
      author.Show();

      Console.ReadKey();
    }
  }
}
