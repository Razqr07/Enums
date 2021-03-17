using System;

namespace Week_2._1_Enums
{
    class Program
    {
        #region part1
        //Part 1: Directions...
        //1. Create an enumerable type named 'Directions' containing all 4 directions north, south, east and west.
        enum Directions
        {
            North,
            South,
            East,
            West
        }

        #endregion


        static void Main(string[] args)
        {
            #region part2
            //Part 2: 
            //1. Declare a variable named 'playerDirection' of the enum 'Directions' type.
            //2. Ask the user to input one of the available directions.
            //3. Use an if statment to check the input and display a different message for every possible option.
            Console.WriteLine("Choose one of these directions... 0 = North, 1 = South, 2 = East, 4 = West ... ");
            int enumID = Convert.ToInt32(Console.ReadLine());
            Directions chosenDir = (Directions)enumID;


            if (chosenDir == Directions.North)
            {
                Console.WriteLine("You chose North...");
            }
            if (chosenDir == Directions.South)
            {
                Console.WriteLine("You chose South...");
            }
            if (chosenDir == Directions.East)
            {
                Console.WriteLine("You chose East...");
            }
            if (chosenDir == Directions.West)
            {
                Console.WriteLine("You chose West...");
            }
            else
            {
                Console.WriteLine("This isnt a choice...");
            }
            #endregion
        }
    }
}
