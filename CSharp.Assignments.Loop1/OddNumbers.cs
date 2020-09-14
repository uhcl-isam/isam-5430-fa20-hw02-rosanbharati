using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number.
        /// Then, Write all odd integers between start and ending number inclusive (in ascending order) 
        /// on separate lines.
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            int begin = int.Parse(Console.ReadLine());
            // Codes to enter start
            Console.Error.WriteLine("Enter the ending number");
            int end = int.Parse(Console.ReadLine());

            int count = 0;
            int n= 0;
            int num = 0;

            
            while(n>=begin && n<=end)
            {
                for(int i=0; i<n; i++)
                {
                    if(n%2!=0)
                    {
                        num = n;
                        count++;

                    }
                    return;

                }
                Console.Write(num);
                Console.ReadLine();
            }
            
            // Codes to enter end.
        }
    }
}
