using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
  class Article
  {
    string name = null;
    string shop = null;
    float price;

    public Article(string name)
    {
      this.name = name;
    }

    public string Name
    {
      get
      {
        return name;
      }
      set
      {
        name = value;
      }
    }
    public string Shop
    {
      get
      {
        return shop;
      }
      set
      {
        shop = value;
      }
    }

    public float Price
    {
      get
      {
        return price;
      }
      set
      {
        price = value;
      }
    }
  }
}
