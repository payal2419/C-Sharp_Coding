
//Create a program to print a number put in by the user
using System;

namespace Demo1
{
    class ConvertToInt
    {
        public static void Main(string[] args)
        {
            int myNum;
            Console.WriteLine("Think of a number: ");
            myNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + myNum);
        }
    }
}
