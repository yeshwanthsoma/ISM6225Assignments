using System;
using System.Collections.Generic;
using System.Text;

namespace InClassTests
{
    class Program4
    {
        public static void Main1(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(" ");
            int x = Convert.ToInt32(split[0]);
            int y = Convert.ToInt32(split[1]);
            int n = Convert.ToInt32(split[2]);
            
            for(int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%y==0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
