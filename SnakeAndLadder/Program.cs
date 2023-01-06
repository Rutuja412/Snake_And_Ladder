using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Program");
            SnakeLadder snakeLadder=new SnakeLadder();
            snakeLadder.Game();
            Console.WriteLine("-----------");
           

        }
    }
}
