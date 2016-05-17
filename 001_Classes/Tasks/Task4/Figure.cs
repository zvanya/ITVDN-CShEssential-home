﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
  class Figure
  {
    Point[] point;

    string type;
    public string Type
    {
      get { return type; }
    }

    public Figure(Point p1, Point p2, Point p3)
    {
      point = new Point[3];
      this.point[0] = p1;
      this.point[1] = p2;
      this.point[2] = p3;
      type = "Треугольник";
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
      point = new Point[4];
      this.point[0] = p1;
      this.point[1] = p2;
      this.point[2] = p3;
      this.point[3] = p4;
      type = "Четырехугольник";
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
      point = new Point[5];
      this.point[0] = p1;
      this.point[1] = p2;
      this.point[2] = p3;
      this.point[3] = p4;
      this.point[4] = p5;
      type = "Пятигольник";
    }

    double LengthSide(Point A, Point B)
    {
      return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
    }

    public void PerimeterCalculator()
    {
      double sum = 0;

      for (int i = 0; i < point.Length - 1; i++)
      {
        sum += LengthSide(point[i], point[i + 1]);
      }

      sum += LengthSide(point[point.Length - 1], point[0]);
      Console.Write(sum);
    }
  }
}
