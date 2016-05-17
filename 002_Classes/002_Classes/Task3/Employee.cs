using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
  class Employee
  {
    string name = null, surname = null;
    int post = 0;
    int seniority = 0;
    double wage = 0;
    double tax = 0;

    public int Post
    {
      set { post = value; }
      get { return post; }
    }
    public int Seniority
    { 
      set { seniority = value; }
      get { return seniority; }
    }

    public Employee(string name, string surname)
    {
      this.name = name;
      this.surname = surname;
    }

    void CalculateWage()
    {
      if (seniority < 2)
      {
        switch (post)
        {
          case 1:
            wage = 500;
            break;
          case 2:
            wage = 1000;
            break;
          case 3:
            wage = 2000;
            break;
          default:
            wage = 0;
            break;
        }
      }
      else if (seniority < 5)
      {
        switch (post)
        {
          case 1:
            wage = 500;
            break;
          case 2:
            wage = 1100;
            break;
          case 3:
            wage = 2200;
            break;
          default:
            wage = 0;
            break;
        }
      }
      else
      {
        switch (post)
        {
          case 1:
            wage = 700;
            break;
          case 2:
            wage = 1200;
            break;
          case 3:
            wage = 2300;
            break;
          default:
            wage = 0;
            break;
        }
      }
    }

    void CalculateTax()
    {

    }

    public void ShowEmployeeInfo()
    {

    }
  }
}
