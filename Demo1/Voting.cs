using System;

namespace Demo1
{
    class Voting
    {
        public static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else
            {
                Console.WriteLine("You are not eligible for voting");
            }
            Console.ReadLine();
        }
    }
}
