using System;

namespace Demo1
{
    class PositiveAndNegative
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            if(n>0)
            {
                Console.WriteLine("The number is Positive");
            }
            else if(n<0)
            {
                Console.WriteLine("The number is Negative");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }
            Console.ReadLine();
        }
    }
}
