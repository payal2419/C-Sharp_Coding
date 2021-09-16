using System;

namespace Demo1
{
    class TrafficSignal
    {
        public static void Main(string[] args)
        {
            string Light;
            Console.WriteLine("Enter the traffic light color");
            Light = Console.ReadLine();
            if(Light=="red" || Light=="Red" || Light=="RED")
            {
                Console.WriteLine("Hey, Hello Stop Right Now");
            }
            else if(Light=="green" || Light=="Green" || Light=="GREEN")
            {
                Console.WriteLine("Hey, You Can Gear Up to Gooooooo");
            }
            else if(Light=="yellow" || Light=="Yellow" || Light=="YELLOW")
            {
                Console.WriteLine("Hey, Slow Down Yellow Signal Here");
            }
            else
            {
                Console.WriteLine("Invalid Color");
            }
            Console.ReadLine();
        }
    }
}
