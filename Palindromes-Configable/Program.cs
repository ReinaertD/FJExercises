using System;
using System.Text.RegularExpressions;

namespace FJExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool UserWantsToQuit = false;
            bool IgnoreUppercase = false;
            bool IgnoreSpecialChars = false;
            while (!UserWantsToQuit)
            {
                Console.WriteLine("Please enter a string and press enter to check if it is a palindrome.");
                Console.WriteLine("If you want to quit type 'quit' and press enter");
                Console.WriteLine("To configure the patterns type in 'config'");

                string Input = Console.ReadLine();

                if (Input == "quit") UserWantsToQuit = true;
                if (Input == "config")
                {
                    Console.WriteLine("Do you want to ignore uppercase? y/n");
                    IgnoreUppercase = (Console.ReadLine().ToLower() == "y") ? true : false;
                    Console.WriteLine("Do you want to ignore special characters? y/n");
                    IgnoreSpecialChars = (Console.ReadLine().ToLower() == "y") ? true : false; 
                    Console.WriteLine("Please enter a string and press enter to check if it is a palindrome.");
                    Input = Console.ReadLine();
                }
                
                Console.WriteLine("---");
                if (PalindromeCheck.CheckPalindrome(Input,IgnoreUppercase,IgnoreSpecialChars)) Console.WriteLine("{0} is a palindrome.",Input);
                else Console.WriteLine("{0} is not a palindrome.",Input);
                Console.WriteLine("---");

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
        public static bool CheckPalindrome(string input, bool ignoreUppercase, bool ignoreSpecialChars)
        {
            if (ignoreUppercase)
            {
                input = input.ToLower();
            }

            string reversedInput = StringReversal.ReverseString(input);

            if(ignoreSpecialChars)
            {
            string rg = "[^a-zA-Z]+";
            reversedInput = Regex.Replace(reversedInput, @rg, "");
            input = Regex.Replace(input, @rg, "");
            }

           return ((reversedInput == input) ?true : false);
        }
    }
}
