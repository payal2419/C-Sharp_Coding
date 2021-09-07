using System;

namespace Demo1
{
    class Addition_Two_Numbers_
    {
        public static void Main(string[] args)
        {
            int a, b, Sum;
            Console.WriteLine("Enter the value for a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for b");
            b = Convert.ToInt32(Console.ReadLine());
            Sum = a + b;
            Console.WriteLine("Addition of two numbers: " + Sum);
            Console.ReadLine();
        }
    }
}
