using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
  class Converter
  {
    double usd, eur, rub;

    public enum fcurrency : int
    {
      usd = 1,
      eur = 2,
      rub = 3
    }

    public Converter(double usd, double eur, double rub)
    {
      this.usd = usd;
      this.eur = eur;
      this.rub = rub;
    }

    public double FromUah(double uah, fcurrency currency)
    {
      switch (currency)
      {
        case fcurrency.usd:
          return uah / this.usd;
        case fcurrency.eur:
          return uah / this.eur;
        case fcurrency.rub:
          return uah / this.rub;
        default:
          return -1;
      }
    }
    public double ToUah(double value, fcurrency currency)
    {
      switch (currency)
      {
        case fcurrency.usd:
          return value * this.usd;
        case fcurrency.eur:
          return value * this.eur;
        case fcurrency.rub:
          return value * this.rub;
        default:
          return -1;
      }
    }
  }
}
