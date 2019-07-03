using System;

namespace InClassSourceControlPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayGreeting();

            String favoriteColor = Console.ReadLine();

            UserColorInformation(favoriteColor);

        }

        /// <summary>
        /// Displays a message to the user
        /// </summary>
        private static void DisplayGreeting()
        {
            Console.WriteLine("Hello there!\nWhat is your favorite primary color?");
        }

        /// <summary>
        /// Feeds information to the user based on their color input
        /// </summary>
        /// <param name="color"></param>
        static void UserColorInformation(string color)
        {
            color = color.ToLower();

            switch (color)
            {
                case "red":
                    PrintRedInformation();
                    break;
                case "blue":
                    PrintBlueInformation();
                    break;
                case "yellow":
                    PrintYellowInformation();
                    break;
                default:
                    Console.WriteLine("\n\n...\n\n\nI don't think that's a primary color.");
                    break;
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Prints out various information about the color yellow
        /// </summary>
        private static void PrintYellowInformation()
        {
            Console.WriteLine("\nYellow paired with the primary color red creates brown." +
                                    "\nYou probably know this, but bananas are yellow." +
                                    "\nSome people think schoolbuses are orange but I think they are yellow.");
        }

        /// <summary>
        /// Prints out various information about the color blue
        /// </summary>
        private static void PrintBlueInformation()
        {
            Console.WriteLine("\nBlue paired with yellow creates the color green." +
                                    "\nThe sky is a commonly used example of the color blue." +
                                    "\nThe tears of my enemies are blue.");
        }

        /// <summary>
        /// Prints out various information about the color red
        /// </summary>
        private static void PrintRedInformation()
        {
            Console.WriteLine("\nRed paired with the primary color blue makes purple." +
                                    "\nCalifornia's state bird is red." +
                                    "\nThe squiggles underneath code that will not compile is also this color.");
        }
    }

    
}
