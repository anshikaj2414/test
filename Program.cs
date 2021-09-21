using System;

namespace ShapeArea
{
    public abstract class Shape
    {
        public static double Pi = 3.14;
        public abstract void area(int x,int y);
    }

    public class Rectangle : Shape
    {
        public override void area(int l,int b)
        {
            Console.WriteLine("Area of Rectangle = {0}",l*b);
        }

        public void area(int side)
        {
            Console.WriteLine("Area of Square = {0}", side * side);
        }
    }
    public class Triangle : Shape
    {
        public override void area(int b, int height)
        {
            Console.WriteLine("Area of Triangle = {0}", 0.5 * b * height);
        }

    }

    public class Circle : Shape
    {
        public override void area(int x, int y)
        {
            Console.WriteLine("Area of Circle = {0}", Pi*x*y);
        }

        public void area(int r)
        {
            Console.WriteLine("Area of Circle = {0}", Pi * r * r);
        }

    }





    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Rectangle r = new Rectangle();
            Circle c = new Circle();
            Triangle t = new Triangle();
            r.area(20, 30);
            r.area(10);
            c.area(10);
            t.area(10, 8);
        }
    }
}
