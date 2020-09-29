using System;

namespace Snake_And_Ladder_simulator
{
    class Program
    {
        //constants
        const int LADDER = 1;
        const int SNAKE = 2;
        const int NO_PLAY = 3;
        static int currentPosition = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator !");
            int numberRolled = Roll();
            Console.WriteLine("You rolled " + numberRolled);
            int position = Movement(numberRolled);
            Console.WriteLine("Your position : " + position);
        }
        static int Roll()
        {
            Random random = new Random();
            int numberOnDice = random.Next(1, 7);
            return numberOnDice;
        }
        static int Movement(int diceValue)
        {
            Random random = new Random();
            int option = random.Next(1, 4);
            switch (option)
            {
                case LADDER:
                    Console.WriteLine("Option selected : Ladder");
                    currentPosition += diceValue;
                    break;
                case SNAKE:
                    Console.WriteLine("Option selected : Snake");
                    currentPosition -= diceValue;
                    break;
                case NO_PLAY:
                    Console.WriteLine("Option selected : No Play");
                    break;
            }
            return currentPosition;
        }

    }
}

