using System;

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

                if (Input == StringReversal.ReverseString(Input)) Console.WriteLine("This is a palindrome.");
                else if (Input.ToLower() == "quit") userWantsToQuit = true;
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
}
