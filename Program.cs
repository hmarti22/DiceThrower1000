using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Thrower_1000
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ThrowDice("10d6");

            ThrowDice("3d20");

            ThrowDice("100d6");
           
            Console.ReadKey();
        }
        static void ThrowDice(string diceString)
        {
          
            Console.WriteLine("Throw dice! ");
            Console.WriteLine("Throw dice! " + diceString);
            List<string> inputList = diceString.Split('d').ToList();
            
            int j = int.Parse(inputList[0]);
            int k = int.Parse(inputList[1]);

            Random randomNumberGenerator = new Random();

            for (int i = 1; i < j + 1; i += 1)
            {
                //random number generator code function
                int randomNum = randomNumberGenerator.Next(1, k + 1);
                Console.Write(randomNum + " ");
            }
            Console.WriteLine();
        }
    }
}

			 
	