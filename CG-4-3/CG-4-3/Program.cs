using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTES FROM CLASS BELOW --> ask user to enter up to 30 names
            Console.WriteLine("Enter 30 names.");

            //track number of names entered
            //why? bc our for loop coutner wil fall out of scope
            int namesEntered = 0;

            //store the names entered into an array
            string[] names = new string[30];

            //loop until we get 30 names or the user hits enter
            //save the input from the user into the array
            for (int i = 0; i < 30; i++)
            {
                //read in a name from the user.
                string nameEntered = Console.ReadLine();

                //if the user hites enter without entering a name assume they're done
                if (nameEntered == "") break;

                //save the name entered into the next element of the array
                names[i] = nameEntered;
                
                //increment our counter
                namesEntered = i;
            }
            //then you will randomly choose a name from the array and write it to the console
            //you can use the ranom classs to generate

            Random randomizer = new Random();

            //the nranomd number generate requires a min and max value
            //our max value needs to be the number of names entered

            int winner = randomizer.Next(0, namesEntered);

            //now we have the index that contains the winner
            //print the calue in that array position not the number of the winner

            Console.WriteLine($"The winner is {names[winner]}!");

            //then you will write the list of other names that did not win

            //loop through all the names
            foreach (string name in names)
            {
                //if the name is NULL we hit the last entered name, stop looping.
                //values in the string array started as null
                //bc we stopped before entering the final blank we can check for null
                if (name == null) break;

                //if the name is winner do not print it
                //make sure you are checking the value of the array

                if (names[winner] == name) continue;

                //print the name because it is a loesr
                Console.WriteLine($"{name} lost.");

            }
            Console.ReadLine();


        }
    }
}
