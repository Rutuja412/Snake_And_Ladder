using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        public void Game()
        {
            int position = 0;
           Console.WriteLine("Single player at the start position " + position);
            Random random = new Random();
            int diceValue = random.Next(1, 7);
          Console.WriteLine(" Rolling Dice Value is " + diceValue);
            int option = random.Next(3);
            if (option == 0)
            {
                Console.WriteLine("No Play");
            }
            else if (option == 1)
            {
                Console.WriteLine("Ladder");
                position += diceValue;
                Console.WriteLine("Current Position is " + position);
            }
            else
            {
                Console.WriteLine("Snake");
                position -= diceValue;
                Console.WriteLine("Current Position is " + position);
            }
        }
    }
}
