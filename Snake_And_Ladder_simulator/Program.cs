using System;

namespace Snake_And_Ladder_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int START_POINT = 0;
            Console.WriteLine("Welcome to Snake and Ladder Simulator !");
            Console.WriteLine("Enter your name");
            string playerName = Console.ReadLine();
            int currentPosition = START_POINT;
            Console.WriteLine("Your position is : " + currentPosition);
        }

    }
}
