using System;

namespace Demo1
{
    class GreatestNumber
    {
        public static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Enter the value for a");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for b");
            B = Convert.ToInt32(Console.ReadLine());
            if(A>B)
            {
                Console.WriteLine("A is the greatest number");
            }
            else
            {
                Console.WriteLine("B is not the greatest number");
            }
        }
    }
}
