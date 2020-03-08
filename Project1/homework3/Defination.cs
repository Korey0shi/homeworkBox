using System;

namespace homework3
{
    interface IShape
    {
        bool IsLegal();
        double CalculateArea();
    }
    public class Rectangle:IShape
    {
        public double Height { set; get; }
        public double Width { set; get; }
        public Rectangle(double height, double width)
        {
            height = Height;
            width = Width;
        }
        public bool IsLegal()
        {
            if (Height <= 0 || Width <= 0)
            {
                return false;
            }
            return true;
        }

        public double CalculateArea()
        {
            if (IsLegal())
            {
                return Height * Width;
            }
            return 0;
        }
    }
    public class Square:IShape
    {
        public double Side { set; get; }
        public Square(double side)
        {
            side = Side;
        }
        public bool IsLegal()
        {
            if (Side <= 0)
            {
                return false;
            }
            return true;
        }
        public double CalculateArea()
        {
            if (IsLegal())
            {
                return Side * Side;
            }
            return 0;
        }
    }
    public class Triangle:IShape
    {
        public double Side1 { set; get; }
        public double Side2 { set; get; }
        public double Side3 { set; get; }
        public Triangle(double side1, double side2, double side3)
        {
            side1 = Side1;
            side2 = Side2;
            side3 = Side3;
        }
        public bool IsLegal()
        {
            if (Side1 + Side2 <= Side3 || Side1 + Side3 <= Side2 || Side2 + Side3 <= Side1 || Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
            {
                return false;
            }
            return true;
        }
        public double CalculateArea()
        {
            if (IsLegal())
            {
                return Math.Sqrt((Side1 + Side2 + Side3) * (Side1 + Side2 - Side3) * (Side1 - Side2 + Side3) * (Side2 + Side3 - Side1)) / 4;
            }
            return 0;
        }

    }



}

