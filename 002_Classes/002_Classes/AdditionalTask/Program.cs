using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
  class User
  {
    readonly string registration_date;

    public string Login { set; get; }
    public string Name { set; get; }
    public string Surname { set; get; }
    public string Age { set; get; }
    public string Registration_date
    {
      get
      {
        return registration_date;
      }
    }

    public User(string registration_date)
    {
      this.registration_date = registration_date;
    }

    public void ShowUserInfo()
    {
      Console.WriteLine("Информация о пользователе:\nLogin: {0}\nName: {1}\nSurname: {2}\nAge: {3}\nRegistration date: {4}", 
                        Login, Name, Surname, Age, Registration_date);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      User user1 = new User(DateTime.Now.ToString());

      Console.Write("Введите информацию о себе:\nLogin: ");
      user1.Login = Console.ReadLine();
      Console.Write("Name: ");
      user1.Name = Console.ReadLine();
      Console.Write("Surname: ");
      user1.Surname = Console.ReadLine();
      Console.Write("Age: ");
      user1.Age = Console.ReadLine();

      Console.WriteLine(new string('-', 30));

      user1.ShowUserInfo();

      Console.ReadKey();
    }
  }
}
