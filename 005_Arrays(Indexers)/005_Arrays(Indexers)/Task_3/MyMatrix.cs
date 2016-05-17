using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
  class MyMatrix
  {
    int[,] m;
    public MyMatrix(int row, int col)
    {
      Random rand = new Random();

      m = new int[row, col];

      for (int i = 0; i < row; i++)
      for (int j = 0; j < col; j++)
      {
        m[i, j] = rand.Next(0, 40);
      }
    }


  }
}
