using System;

namespace InClassSourceControlPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there!\nWhat is your favorite primary color?");

            String favoriteColor = Console.ReadLine();
        }
    }

    private static void UserColorInformation(string color)
    {
        color = color.ToLower();

        switch (color)
        {
            case "red":
                Console.WriteLine("\nRed paired with the primary color blue makes purple." +
                    "\nCalifornia's state bird is red." +
                    "\nThe squiggles underneath code that will not compile is also this color.");
                break;
            case "blue":
                Console.WriteLine("\nBlue paired with yellow creates the color green." +
                    "\nThe sky is a commonly used example of the color blue." +
                    "\nThe tears of my enemy are blue.");
                break;
            case "yellow":
                Console.WriteLine("\nYellow paired with the primary color red creates brown." +
                    "\nYou probably know this, but bananas are yellow." +
                    "\nSome people think schoolbuses are orange but I think they are yellow.");
                break;
            default:
                Console.WriteLine("\n\n...\n\n\nI don't think that's a primary color.");
                break;
        }
        Console.ReadKey();
    }
}
