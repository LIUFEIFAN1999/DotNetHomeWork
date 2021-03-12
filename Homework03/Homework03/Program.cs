using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    abstract class Shape
    {
        protected double length;
        protected double width;
        protected double area;
        abstract public double GetArea();

        public double Length
        {
            get;set;
        }
        public double Width
        {
            get;set;
        }
    }

    class Rectangle : Shape {
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            if (length > 0 && width > 0)
            {
                area = width * length;
                return area;
            }
            else
            {
                return -1;
            }
        }
    }

    class Square : Shape
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
            length = width = side;
        }
        public double Side
        {
            set
            {
                width = length = side = value;
            }
            get
            {
                return side;
            }
        }
        public override double GetArea()
        {
            if (side > 0 && length == width)
            {
                area = side * side;
                return area;
            }
            else
            {
                return -1;
            }
        }
    }

    class Triangle : Shape
    {
        public Triangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            if (length > 0 && width > 0)
            {
                area = (width * length) / 2;
                return area;
            }
            else
            {
                return -1;
            }
        }
    }

    class Factory
    {
        //创建矩形和三角形对象
        public static Shape Manufacture(string shapeName, double length, double width)
        {
            switch (shapeName)
            {
                case "Rectangle": return new Rectangle(length, width);
                case "Triangle": return new Triangle(length, width);
                default: return null;
            }
        }
        //overload
        //创建正方形
        public static Shape Manufacture(string shapeName, double side)
        {
            if (shapeName == "Square")
            {
                return new Square(side);
            }
            else
            {
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] shapes = {"Rectangle","Square","Triangle","Illegal"};
            double[] sides = {1, 2, 3, 4, 5, 1.5, 2.5, 3.5 };
            string _shape;
            double _length, _width,_side;
            double totalArea = 0;
            Shape shape;
            for(int index = 1; index <= 10; index++)
            {
                _shape = shapes[index % 3]; //0矩形、1正方形、2三角形
                _length = _side = sides[index % 8]; //选取长、边长
                _width = sides[(index+1) % 8]; //选取宽
                try
                {
                    if (_shape == "Square")
                    {
                        shape = Factory.Manufacture(_shape, _side);
                    }
                    else
                    {
                        shape = Factory.Manufacture(_shape, _length, _width);
                    }
                    if (shape.GetArea() == -1)
                    {
                        Console.WriteLine($"第{index}个形状不合法！");
                        Environment.Exit(0);
                    }
                    totalArea += shape.GetArea();
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine($"形状有误:{e.Message}");
                    Environment.Exit(0);
                }
                
            }
            Console.WriteLine($"十个形状的总面积：{totalArea}");
        }
    }
}
