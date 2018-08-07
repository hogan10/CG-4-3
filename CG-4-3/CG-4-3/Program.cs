using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //We start simply by asking the user to input 30 names
            Console.WriteLine("Please enter 30 names. Press enter after each name.");
            Console.Write("Enter the first name here: ");

            //The 30 names will be our array. we need to set up the array now
            var names = new String[30];
            var numberallnames = 0;

            //next we have the loop that tells us we are going from 0
            //up to 30
            for (int i = 0; i < 30; i++)
            {
                //next we string all of the names
                var userInput = Console.ReadLine();
                //next we use a break in case they hit enter without
                //entering a name
                if (string.IsNullOrWhiteSpace(userInput)) break;
                names[i] = userInput;
                numberallnames = 1;

            }

            //next we need to draw names at random
            var rnd = new Random();
            var winner = rnd.Next(numberallnames);

            //we need to write the winner to the console
            Console.WriteLine(names[numberallnames] + " is the lucky winner!!");

            //Now we list everyone that did not win 
            Console.WriteLine("Sorry, the names listed did not win.");

            //we can list this using a loop!
            for (int x = 0; x <= numberallnames; x++)
            {
                if (x == winner) continue;
                Console.WriteLine(names[x]);

            }
            //Actually list everything to the screen:
            Console.Read();
        }
    }
}
