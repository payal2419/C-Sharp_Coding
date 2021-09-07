using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Even_Odd
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number(n): ");
            n = Convert.ToInt32 (Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("It is a Even Number");
            }
            else  
            {
                Console.WriteLine("It is a Odd Number");
            }
            Console.ReadLine();
        }
    }
}
