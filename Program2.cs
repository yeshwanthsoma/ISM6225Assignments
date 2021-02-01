using System;
using System.Collections.Generic;
using System.Text;

namespace InClassTests
{
    class Program2
    {
        public static void Main1(string[] args)
        {

            string input = Console.ReadLine();
           
            foreach (char i in input)
            {
                if (Char.IsUpper(i))
                {
                    Console.Write(i);
                }
            }
        }
    }
}
