
using System;
using System.Collections;
using System.Collections.Generic;



namespace InClassTests
{
    class Assignment1
    {
        static void Main(string[] args)
        {

            //Question 1
            Console.WriteLine("Q1 : Enter the number of rows for the traingle:");
            int n = Convert.ToInt32(Console.ReadLine());
            printTriangle(n);
            Console.WriteLine();

            //Question 2:
            Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            printPellSeries(n2);
            Console.WriteLine();

            //Question 3:
            Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            bool flag = squareSums(n3);
            if (flag)
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }

            //Question 4:
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            int n4 = diffPairs(arr, k);
            Console.WriteLine("There exists {0} pairs with the given difference", n4);

            //Question 5:
            List<string> emails = new List<string>();
            emails.Add("dis.email + bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            Console.WriteLine("Q5");
            Console.WriteLine("The number of unique emails is " + ans5);

            //Quesiton 6:
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
            string destination = DestCity(paths);
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);

        }

        /// <summary>
        ///Print a pattern with n rows given n as input
        ///n – number of rows for the pattern, integer (int)
        ///This method prints a triangle pattern.
        ///For example n = 5 will display the output as: 
        ///     *
        ///    ***
        ///   *****
        ///   *******
        ///  *********
        ///returns      : N/A
        ///return type  : void
        /// </summary>
        /// <param name="n"></param>
        private static void printTriangle(int n)
        {
            try
            {
                for (int i = 0; i < n; i++) //looping until n numbers
                {
                    string input1 = new string(' ', n - i - 1); //creates a string of same char for n number of times 
                    Console.Write(input1);     //printing the string 
                    string input2 = new string('*', (i * 2) + 1);
                    Console.Write(input2);
                    Console.WriteLine();    //Goto Next line
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        ///<para>
        ///In mathematics, the Pell numbers are an infinite sequence of integers.
        ///The sequence of Pell numbers starts with 0 and 1, and then each Pell number is the sum of twice of the previous Pell number and 
        ///the Pell number before that.:thus, 70 is the companion to 29, and 70 = 2 × 29 + 12 = 58 + 12. The first few terms of the sequence are :
        ///0, 1, 2, 5, 12, 29, 70, 169, 408, 985, 2378, 5741, 13860,… 
        ///Write a method that prints first n numbers of the Pell series
        /// Returns : N/A
        /// Return type: void
        ///</para>
        /// </summary>
        /// <param name="n2"></param>
        private static void printPellSeries(int n2)
        {
            try
            {
                long p1 = 0, p2 = 1;     //Declaring long as we are dealing with large integers(Int64)
                long temp;
                for (int i = 0; i < n2; i++)    //looping until n numbers
                {
                    if (i == 0 || i == 1)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        temp = 2 * p2 + p1;         //Pell numbers logic
                        Console.Write(temp + " ");
                        p1 = p2;                    //swaping the last two numbers
                        p2 = temp;

                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }


        /// <summary>
        ///Given a non-negative integer c, decide whether there're two integers a and b such that a^2 + b^2 = c.
        ///For example:
        ///Input: C = 5 will return the output: true (1*1 + 2*2 = 5)
        ///Input: A = 3 will return the output : false
        ///Input: A = 4 will return the output: true
        ///Input: A = 1 will return the output : true
        ///Note: You cannot use inbuilt Math Class functions.
        /// </summary>
        /// <param name="n3"></param>
        /// <returns>True or False</returns>

        private static bool squareSums(int n3)
        {
            try
            {
                double max = Math.Floor(Math.Sqrt(n3));  //finding the square root to find the max number to iterate
                double res;
                for (int i = 0; i <= max; i++)  
                {
                    res = Math.Sqrt(n3 - (i * i));
                    if (res - Math.Floor(res) == 0)     //finding if squareRoot(c-square(b))=a  
                    {
                        return true;
                    }
                }

                return false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        /// <summary>
        /// Given an array of integers and an integer n, you need to find the number of unique
        /// n-diff pairs in the array.Here a n-diff pair is defined as an integer pair (i, j),
        ///where i and j are both numbers in the array and their absolute difference is n.
        ///Example 1:
        ///Input: [3, 1, 4, 1, 5], k = 2
        ///Output: 2
        ///Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
        ///Although we have two 1s in the input, we should only return the number of unique   
        ///pairs.
        ///Example 2:
        ///Input:[1, 2, 3, 4, 5], k = 1
        ///Output: 4
        ///Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and
        ///(4, 5).
        ///Example 3:
        ///Input: [1, 3, 1, 5, 4], k = 0
        ///Output: 1
        ///Explanation: There is one 0-diff pair in the array, (1, 1).
        ///Note : The pairs(i, j) and(j, i) count as same.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns>Number of pairs in the array with the given number as difference</returns>
        private static int diffPairs(int[] nums, int k)
        {
            try
            {
                Array.Sort(nums);
                ArrayList values = new ArrayList();
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++) //Iterating through all the numbers in the Array
                    {
                        if (nums[i] == nums[j] && k != 0)       //if there are duplicate numbers we are skipping them
                        {
                            break;
                        }
                        if (Math.Abs(nums[i] - nums[j]) == k)   
                        {
                            string num = nums[i] + "" + nums[j];
                            if (!values.Contains(num))          //checking if the pair is already existing
                            {
                                values.Add(num);     //adding the pair that satisfies the difference to the array list
                            }
                        }
                    }
                }
                return values.Count;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }

        /// <summary>
        /// An Email has two parts, local name and domain name. 
        /// Eg: rocky @usf.edu – local name : rocky, domain name : usf.edu
        /// Besides lowercase letters, these emails may contain '.'s or '+'s.
        /// If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.
        /// For example, "bulls.z@usf.com" and "bullsz@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)
        /// If you add a plus('+') in the local name, everything after the first plus sign will be ignored.This allows certain emails to be filtered, for example ro.cky+bulls @usf.com will be forwarded to rocky@email.com.  (Again, this rule does not apply for domain names.)
        /// It is possible to use both of these rules at the same time.
        /// Given a list of emails, we send one email to each address in the list.Return, how many different addresses actually receive mails?
        /// Eg:
        /// Input: ["dis.email+bull@usf.com","dis.e.mail+bob.cathy@usf.com","disemail+david@us.f.com"]
        /// Output: 2
        /// Explanation: "disemail@usf.com" and "disemail@us.f.com" actually receive mails
        /// </summary>
        /// <param name="emails"></param>
        /// <returns>The number of unique emails in the given list</returns>

        private static int UniqueEmails(List<string> emails)
        {
            try
            {
                int flagAt = 0;
                int flagPlus = 0;
                int i = 0;
                int j = 0;
                
                ArrayList values = new ArrayList();
                string[] newEmails = new string[emails.Count];  //creating the string array
                foreach (String p in emails)
                {
                    char[] email = new char[p.Length];      //creating the char array 
                    i = 0;
                    foreach (char ch in p)
                    {
                        if (flagPlus == 1 && flagAt == 0 && ch != '@')
                        {
                            continue;
                        }
                        if (ch == '.' && flagAt == 0)  //if we encounter '.' ignore it 
                        {
                            continue;
                        }
                        if (ch == '+' && flagAt == 0)  //if we encounter '+' then ignore all until '@'
                        {
                            flagPlus = 1;
                            continue;
                        }
                        if (ch == '@')          //changing flag if we encounter '@'
                        {
                            flagAt = 1;
                            flagPlus = 0;
                        }
                        if (ch == ' ')          //if we encounter " " then ignore it
                        {
                            continue;
                        }
                        email[i] = ch;
                        i++;

                    }
                    flagAt = 0;
                    newEmails[j] = new string(email);    //creating the string with the all the char 
                    newEmails[j] = newEmails[j].Replace("\0", string.Empty); // replace the null as empty strings
                    if (!(values.Contains(newEmails[j])))   //remove the duplicate filtered email ids
                    {
                        values.Add(newEmails[j]);
                    }
                    j++;
                }
                return values.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /// <summary>
        /// You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.
        /// It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
        /// Example 1:
        /// Input: paths = [["London", "New York"], ["New York","Tampa"], ["Delhi","London"]]
        /// Output: "Tampa" 
        /// Explanation: Starting at "Delhi" city you will reach "Tampa" city which is the destination city.Your trip consist of: "Delhi" -> "London" -> "New York" -> "Tampa".
        /// Input: paths = [["B","C"],["D","B"],["C","A"]]
        /// Output: "A"
        /// Explanation: All possible trips are: 
        /// "D" -> "B" -> "C" -> "A". 
        /// "B" -> "C" -> "A". 
        /// "C" -> "A". 
        /// "A". 
        /// Clearly the destination city is "A".
        /// </summary>
        /// <param name="paths"></param>
        /// <returns>The destination city string</returns>
        private static string DestCity(string[,] paths)
        {
            try
            {
                bool destFound = false;
                string search = paths[0, 1];        //starting from the first destination city
                int flag=0;
                while (!destFound)
                {
                    flag = 0;
                    for (int i = 1; i < (paths.Length)/2; i++)      //iterating through all the paths
                    {
                        if (search == paths[i, 0])              //if found the destination, search for next destination point
                        {
                            search = paths[i, 1];
                            flag = 1;
                            break;                      
                        }
                    }
                    if (flag == 0)
                    {
                        destFound = true;       //if the next destination is not found then it is the final one.
                    }
                }
                return search;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }


    }
}
/*    Self Reflection:
 *    In the diffPairs Problem I have started using ArrayLists to find the duplicates which is new that I ahve learnt
 *    Also got to know the IDE of visual studio and also the many features like Debugging.
 *    Also in the printTriangle problem I have learnt how to create the same character many number of times
 *    I have taken around 3-4 hours to complete the whole assignment */



