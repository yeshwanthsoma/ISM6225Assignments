using System;
using System.Collections.Generic;
using System.Text;

namespace InClassTests
{
    class Program3
    {
        public static void Main1(string[] args)
        {
            string input = Console.ReadLine();
            int[] numInput = new int[3];

            string[] split = input.Split(" ");
            numInput[0] = Convert.ToInt32(split[0]);
            numInput[1] = Convert.ToInt32(split[1]);
            numInput[2] = Convert.ToInt32(split[2]);
            int two=Math.Max((numInput[0] - numInput[1]) * (numInput[0] - numInput[2]), (numInput[0] - numInput[1]) * numInput[2]);
            int one = Math.Max(numInput[1] * numInput[2], numInput[1] * (numInput[0] - numInput[2]));
                
                

            Console.WriteLine(Math.Max(two,one)*4);
            
            


        } 
    }
}
