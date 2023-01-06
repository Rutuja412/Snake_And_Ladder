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
            int WINNINGPOSITION = 100;
            while (position <= WINNINGPOSITION)
            {
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
                else if (option == 2)
                {
                    Console.WriteLine("Snake");
                    position -= diceValue;
                    Console.WriteLine("Current Position is " + position);

                    if (position < 0)
                    {
                        position = 0;
                        Console.WriteLine("Current Position is =" + position);
                    }
                }
                
                position++;
                if (position == WINNINGPOSITION)
                {
                    Console.WriteLine("Player at Winning Position");
                }
            }
        }
    }
}
