using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class PositiveInts
    {
        /// <summary>
        /// First prompt for the value of n, then Write all the positive integers up to 
        /// the integer n on separate lines. [Demonstration]
        /// </summary>
        public static void Main()
        {
            Console.Error.WriteLine("Enter the value of n");
            int n = int.Parse(Console.ReadLine());
            int positive = 0;
            int num = 0;
            int count = 0;
           
            

            while(num>0 && num<=n)
            {
                for(int i=0; i<n; i++)
                {
                    if (num % 2 == 0)
                    {
                        num = positive;
                        ++count;
                    }
                }
                Console.WriteLine("The positive integers are:");
                Console.Write(positive);
                Console.ReadLine();
            }

            // write your codes here.
        }
    }
}
