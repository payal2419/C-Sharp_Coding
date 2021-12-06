
//Create a program to get user input, stored in the variable userName
using System;

namespace Demo1
{
    class UserInput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the UserName: ");
            string userName = Console.ReadLine(); //to take input from user
            Console.WriteLine("The UserName is: " + userName);
        }
    }
}
