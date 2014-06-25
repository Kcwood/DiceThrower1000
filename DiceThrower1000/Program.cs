using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling the function ThrowDice
            //with the parameter 10d6
            ThrowDice("10d6");
            //Calling the function ThrowDice
            //with the parameter 3d20
            ThrowDice("3d20");
            //Calling the function ThrowDice
            //with the parameter 100d6
            ThrowDice("100d6");

            //Keeps the console open
            Console.ReadKey();
        }
        //Creating the function ThrowDice that 
        //will out the results of dice throws
        static void ThrowDice(string diceString)
        {
            //Taking our string and splitting it
            //at 'd' to represent two seperate lists
            string[] Temp = diceString.Split('d');
            //Setting up the list of how
            //many times the die gets rolled
            string diceRolls = Temp[0];
            //Setting up the list of how 
            //many sides the die has
            string diceSides = Temp[1];
            //Turning the roll total from a 
            //string into a number
            int diceRollTot = int.Parse(diceRolls);
            //Turning the side total from a 
            //string into a number
            int diceSideTot = int.Parse(diceSides);
            //Setting up our random number generator
            Random randomNumGen = new Random();
            //Setting up to show what the next
            //random number will be after 
            //the first roll is done
            int randomNum = randomNumGen.Next(1, diceRollTot + 1);
            //Printing to the console
            Console.WriteLine("Throwing: " + diceString);
            //Printing to the console
            Console.Write("Random #: ");
            //Setting up the for loop to run 
            //for the number of rolls
            for (int i = 1; i <= diceRollTot; i++)
            {
                Console.Write(randomNumGen.Next(1, diceSideTot + 1) + " ");
            }

            Console.WriteLine();  
        }
    }
}
