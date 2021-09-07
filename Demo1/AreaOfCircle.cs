using System;

namespace Demo1
{
    class AreaOfCircle
    {
        public static void Main(string[] args)
        {
            double r, Area;
            Console.WriteLine("Enter the value for r");
            r = Convert.ToDouble(Console.ReadLine());
            Area = 3.14 * r * r;
            Console.WriteLine("Area of Circle is: " + Area);
            Console.ReadLine();
        }
    }
}
