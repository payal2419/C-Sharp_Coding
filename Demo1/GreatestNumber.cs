using System;

namespace Demo1
{
    class GreatestNumber
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the value for a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for b");
            b = Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("It is the greatest number");
            }
            else
            {
                Console.WriteLine("It is not the greatest number");
            }
        }
    }
}
