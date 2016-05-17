using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
  class Program
  {
    static void Main(string[] args)
    {
      string title, content, author;

      Console.Write("Введите название книги: ");
      title = Console.ReadLine();
      Console.Write("Введите содержимое книги: ");
      content = Console.ReadLine();
      Console.Write("Введите автора книги: ");
      author = Console.ReadLine();

      Book b1 = new Book(title);
      b1.Content = content;
      b1.Author = author;

      b1.Show();
    }
  }
}
