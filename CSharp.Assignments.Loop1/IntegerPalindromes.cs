using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {

            Console.WriteLine("Enter a number that is 9 digit long:");
            string num = Console.ReadLine();
            while (num.Length > 9 || num.Length < 9)
            {
                Console.WriteLine("The number you entered is invalid. Please try another number.");
                num = Console.ReadLine();

            }
            int n, r, sum = 0, temp;
            n = int.Parse(num);
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("a Palindrome.");
            else
                Console.Write("not a Palindrome");
        }
    }
}
