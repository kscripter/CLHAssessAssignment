using System;

namespace StringManipulation1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //ask for user input
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();//store user input a variable
            word = word.ToLower();// convert user input to lower case

            string reverseWord = "";//a variable to reverse the user input string


            //loop through the word from user
            for (int i = word.Length - 1; i >= 0; i--)
           
            {

                reverseWord = reverseWord + word[i];
            }

            //check if reverseWord is equal to user input
            if (reverseWord == word)
            {
                //if its equal
                Console.WriteLine($"{word} is a palindrome");
            }
            else
            {
                // if its not equal
                Console.WriteLine($"{word} is not a palindrome");
            }

        }
    }
}
