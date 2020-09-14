using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            int count = 0;
            int i = 0;
            var array = (",");
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                }
                else if (array[i] != array[i + 1])
                {
                    return;
                }

                Console.WriteLine(count);
            }
        }
    }
}
