using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
  class Store
  {
    Article[] article;

    public Store(int size)
    {
      article = new Article[size];
      for (int i = 0; i < size; i++)
      {
        article[i] = null;
      }
    }

    public void Add(string product_name, string shop, float price)
    {
      for (int i = 0; i < article.Length; i++)
      {
        if (article[i] != null)
        {
          article[i] = new Article(product_name);
          article[i].Shop = shop;
          article[i].Price = price;
          return;
        }
      }
      Console.WriteLine("Все позиции в магазине заняты.");
    }
    public void Update(string product_name, string new_product_name, string new_shop, float new_price)
    {
      for (int i = 0; i < article.Length; i++)
      {
        if (article[i].Name == product_name)
        {
          article[i].Name = new_product_name;
          article[i].Shop = new_shop;
          article[i].Price = new_price;
          return;
        }
      }
      Console.WriteLine("Такого товара в магазине нет.");
    }
    public void Update(string product_name, string new_product_name, string new_shop)
    {
      for (int i = 0; i < article.Length; i++)
      {
        if (article[i].Name == product_name)
        {
          article[i].Name = new_product_name;
          article[i].Shop = new_shop;
          return;
        }
      }
      Console.WriteLine("Такого товара в магазине нет.");
    }
    public void Update(string product_name, string new_shop, float new_price)
    {
      for (int i = 0; i < article.Length; i++)
      {
        if (article[i].Name == product_name)
        {
          article[i].Shop = new_shop;
          article[i].Price = new_price;
          return;
        }
      }
      Console.WriteLine("Такого товара в магазине нет.");
    }
    public void Update(string product_name, string new_product_name)
    {
      for (int i = 0; i < article.Length; i++)
      {
        if (article[i].Name == product_name)
        {
          article[i].Name = new_product_name;
          return;
        }
      }
      Console.WriteLine("Такого товара в магазине нет.");
    }
    public void ShowInfo(string product_name)
    {

    }
  }
}
