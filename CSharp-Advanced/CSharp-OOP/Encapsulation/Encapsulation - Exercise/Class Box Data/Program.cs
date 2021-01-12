using System;

namespace ClassBoxData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            try
            {
                var box = new Box(length, width, height);
                box.SurfaceArea();
                box.LateralSurfaceArea();
                box.Volume();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
