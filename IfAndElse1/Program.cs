using System.Collections.Generic;
using System.Linq;
using System;

namespace IfAndElse1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array of four colors
            string[] selectedColors = PickRandomColors();
            foreach (var item in selectedColors)//loop through the array of colors
            {
                Console.WriteLine(item);//it will change the color each time the program starts
            }

            int count = 1;

            while (count <= 12)//loop the user input
            {
                Console.WriteLine("Pick four diffrent colors from: (yellow, blue, green, red, orange, purple)");

                string[] userColors = new string[4];//an array to store the four colors entered by the user

                //loop will read each color and store in the variable
                for (int i = 0; i < userColors.Length; i++)
                {
                    Console.Write($"Enter color {i + 1}: ");//read the color and add increment to take another input
                    userColors[i] = Console.ReadLine().ToLower();//read the input and covert to lowerCase
                }

                //guess the correct colors
                //if colors guess colors are in the correct other
                if (IsPerfectColor(selectedColors, userColors))
                {
                    Console.WriteLine("You guessed all the colors correctly in the right order!!!");
                    return;
                }

                //if colors are correctly ordered black is given
                int blacks = GetBlack(selectedColors, userColors);
                int whites = GetWhite(selectedColors, userColors);

                Console.WriteLine("Black: " + blacks);
                Console.WriteLine("White: " + whites);


                count++;
            }

        }


        //method will pick random colors from the colors below
        public static string[] PickRandomColors()
        {
            Random random = new Random();
            string[] colors = { "yellow", "blue", "green", "red", "orange", "purple" };

            //create a list of the colors
            List<string> selectedColors = new List<string>();

            //loop through the selectedColors
            //while the colors entered are less than 4
            while (selectedColors.Count < 4)
            {
                //a variable to store 
                int randomIndex = random.Next(0, colors.Length);

                string randomColor = colors[randomIndex];

                if (selectedColors.IndexOf(randomColor) == -1)
                {
                    selectedColors.Add(randomColor);
                }
            }

            return selectedColors.ToArray();
        }

        public static bool IsPerfectColor(string[] computerColors, string[] userColors)
        {
            bool isPerfectColor = true;

            for (int i = 0; i < 4; i++)
            {
                if (computerColors[i] != userColors[i])
                {
                    isPerfectColor = false;
                    break;
                }
            }

            return isPerfectColor;
        }

        public static int GetBlack(string[] computerColors, string[] userColors)
        {
            int blacks = 0;

            for (int i = 0; i < 4; i++)
            {
                if (computerColors[i] == userColors[i])
                {
                    blacks++;
                }
            }

            return blacks;
        }

        public static int GetWhite(string[] computerColors, string[] userColors)
        {
            int whites = 0;

            List<string> computerColorsList = computerColors.ToList();

            foreach (var color in userColors)
            {
                int index = computerColorsList.IndexOf(color);
                if (index != -1 && userColors[index] != color)
                {
                    whites++;
                }
            }

            return whites;
        }
    }
}
