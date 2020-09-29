using System;

namespace Snake_And_Ladder_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator !");
            Console.WriteLine("Enter your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("Number rolled on the die : " + Roll());
        }
        static int Roll()
        {
            Random random = new Random();
            int diceValue = random.Next(1, 7);
            return diceValue;
        }
    }
}


