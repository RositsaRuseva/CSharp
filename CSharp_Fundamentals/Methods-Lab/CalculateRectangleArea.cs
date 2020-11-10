using System;

namespace CalculateRectangeArea
    //works both ways
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //double area = GetRectangleArea(width, height);
            //Console.WriteLine(area);
            Console.WriteLine(GetRectangleArea(width, height));


        }

        static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            // return width * height;
            return area;
        }
    }
}
