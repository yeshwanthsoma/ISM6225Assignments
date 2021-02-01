using System;
using System.Collections.Generic;
using System.Text;

namespace InClassTests
{
    class Program5
    {
        public static void Main1(string[] args)
        {
            String input=Console.ReadLine();
            int[] numInput = new int[3];
            int temp;
            numInput[0] = 1;
            numInput[1] = 0;
            numInput[2] = 0;
            
            foreach(char a in input)
            {
                if (a == 'A')
                {
                    swap(numInput,0,1);

                }
                else if (a == 'B')
                {
                    swap(numInput, 1, 2);
                }
                else
                {
                    swap(numInput, 0, 2);
                }
            }
            for (int i = 0; i <=2; i++)
            {
                if (numInput[i] == 1)
                {
                    Console.WriteLine(i + 1);
                }
            }
            
            

        }

        private static void swap(int[] numInput,int i,int j)
        {
            int temp = numInput[i];
            numInput[i] = numInput[j];
            numInput[j] = temp;
        }
    }
}
