using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
  class Point
  {
    int x = 0, y = 0;
    string name = null;

    public int X
    {
      get
      {
        return x;
      }
    }
    public int Y
    {
      get
      {
        return y;
      }
    }
    public string Name
    {
      get
      {
        if (name != null)
          return name;
        else return "name";
      }
    }

    public Point(int x, int y, string name)
    {
      this.x = x;
      this.y = y;
      this.name = name;
    }
  }
}
