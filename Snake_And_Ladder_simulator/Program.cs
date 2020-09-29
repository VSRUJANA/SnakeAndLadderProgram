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
        static int currentPosition1 = 0;
        static int currentPosition2 = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladders game");
            Console.WriteLine("Enter player 1 name");
            string player1 = Console.ReadLine();
            Console.WriteLine("Enter player 2 name");
            string player2 = Console.ReadLine();
            while (currentPosition < 100)
            {
                int score1 = Roll();
                currentPosition = currentPosition1;
                currentPosition1 = Movement(score1);
                //Console.WriteLine("player 1 rolled " + score1 + " and is at " + currentPosition1);
                int score2 = Roll();
                currentPosition = currentPosition2;
                currentPosition2 = Movement(score2);
                //Console.WriteLine("player 2 rolled " + score2 + " and is at " + currentPosition2);
            }
            if (currentPosition1 == 100)
            {
                Console.WriteLine(player1 + " won the game!");
            }
            else
            {
                Console.WriteLine(player2 + " won the game!");
            }

            static int Roll()
            {
                Random random = new Random();
                int diceValue = random.Next(1, 7);
                return diceValue;
            }
            static int Movement(int score)
            {
                Random random = new Random();
                int option = random.Next(1, 4);
                switch (option)
                {
                    case LADDER:
                        currentPosition += score;
                        if (currentPosition > 100)
                            currentPosition -= score;
                        Movement(currentPosition);
                        break;
                    case SNAKE:
                        currentPosition -= score;
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
}

