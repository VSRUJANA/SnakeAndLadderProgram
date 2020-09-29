using System;

namespace Snake_And_Ladder_simulator
{
    class Program
    {
        //constants
        const int START_POINT = 0;
        const int LADDER = 1;
        const int SNAKE = 2;
        const int NO_PLAY = 3;
        static int currentPosition = 0;
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Welcome to Snake and Ladder Simulator !");
            do
            {
                int numberRolled = Roll();
                currentPosition = Movement(numberRolled);
                i++;
                Console.WriteLine("Dice Roll number " + i + " - " + " your position : " + currentPosition);

            }
            while (currentPosition < 100);
            Console.WriteLine("Game over! You rolled the dice " + i + " times to win the game");
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
                    currentPosition += diceValue;
                    if (currentPosition > 100)
                        currentPosition -= diceValue;

                    break;
                case SNAKE:
                    currentPosition -= diceValue;
                    if (currentPosition < 0)
                        currentPosition = 0;
                    break;
                case NO_PLAY:
                    break;
            }
            return currentPosition;
        }
    }
}

