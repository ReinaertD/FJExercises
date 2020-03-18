using System;
using System.Text.RegularExpressions;

namespace FJExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userWantsToQuit = false;
            while (!userWantsToQuit)
            {
                Console.WriteLine("Please enter a string to check if it is a palindrome");
                string Input = Console.ReadLine();
          
                if (Input == "quit") userWantsToQuit = true;
                if (PalindromeCheck.CheckPalindrome(Input)) Console.WriteLine("This is a palindrome.");
                else Console.WriteLine("This is not a palindrome.");

            }
        }
    }

    static class StringReversal
    {
        public static string ReverseString(string input)
        {
            char[] letterArray = input.ToCharArray();
            Array.Reverse(letterArray);
            return new string(letterArray);
        }
    }

    static class PalindromeCheck
    {
        public static bool CheckPalindrome(string input)
        {
            string reversedInput = StringReversal.ReverseString(input);
            string rg = "[^a-zA-Z]+";
            Console.WriteLine(reversedInput);
            reversedInput = Regex.Replace(reversedInput, @rg, "");
            input = Regex.Replace(input, @rg, "");
            Console.WriteLine(reversedInput);

            if (reversedInput == input) return true;
            else return false;
        }
    }
}
