using System;

namespace InClassTests
{
    class Program
    {
        static void Main1(string[] args)
        {
            string input = Console.ReadLine();
            int i = 0;
            try
            {
                for (i = 0; i < Convert.ToInt32(input); i++)
                {
                    Console.WriteLine((i + 1) + " " + "Abracadabra");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}
