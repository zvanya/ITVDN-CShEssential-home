using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Venicle
  {
    double x = 0;
    double y = 0;
    double price = 0;
    double speed = 0;
    int model_year = 0;

    public Venicle(double x, double y, double price, double speed, int model_year)
    {
      this.x = x;
      this.y = y;
      this.price = price;
      this.speed = speed;
      this.model_year = model_year;
    }

    public double X
    {
      set { x = value; }
      get { return x;  }
    }
    public double Y
    {
      set { y = value; }
      get { return y; }
    }
    public double Price
    {
      get { return price; }
    }
    public double Speed
    {
      set { speed = value; }
      get { return speed; }
    }
    public int Model_year
    {
      get { return model_year; }
    }
  }

  class Plane : Venicle
  {
    double height = 0;
    int client_count = 0;

    public Plane(double height, int client_count, double x, double y, double price, double speed, int model_year) 
      : base (x, y, price, speed, model_year)
    { }

    public double Height
    {
      get { return height; }
    }
    public int Client_count
    {
      set { client_count = value; }
      get { return client_count; }
    }
  }

  class Ship : Venicle
  {
    int client_count = 0;
    string port = null;

    public Ship(string port, int client_count, double x, double y, double price, double speed, int model_year) 
      : base (x, y, price, speed, model_year)
    { }

    public int Client_count
    {
      set { client_count = value; }
      get { return client_count; }
    }
    public string Port
    {
      set { port = value; }
      get { return port; }
    }
  }
}
