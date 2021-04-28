using System;
using System.Collections.Generic;

namespace StringManipulation2b
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            //ask input from user
            Console.Write("Enter a string: ");
            string word = Console.ReadLine().ToLower();//store user input

            //create a list to hold the unique characters
            List<string> uniqueCharacters = new List<string>();

            //loop through the word to pick one character
            for (int i = 0; i < word.Length; i++)
            {
                string character = word.Substring(i, 1);//

                //check if unique character exist
                if (uniqueCharacters.IndexOf(character) == -1)//if it does not exist (-1)
                {
                    uniqueCharacters.Add(character);//add 1 to the unique character
                    int count = 0;

                    //loop through the word to compare each character in the word
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j].ToString() == character)//pick a character and convert to string
                        {
                            count++;//increament the character by one
                        }
                    }

                    Console.WriteLine($"The number of occourence of {character} is {count}");

                }
            }


        }
    }
}
