using System;

namespace rockpaperscissors2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int cpuInput = random.Next(0, 3);
            int playerScore = 0;
            int cpuScore = 0;
            int gameCount = 0;
            string playerInput;
            int gameMode = 3;
            bool validGameMode = false;
            int bestOf = 1;
            int maxScoreCount = 1;
            bool gameContinues = true;

            Console.WriteLine("Welcome to Rock Paper Scissors 2!");

            //gamemode selector
            while (!validGameMode)
            {
                Console.WriteLine("Best of ... - 1");
                Console.WriteLine("First to ... - 2");
                Console.WriteLine("Endless - 3");
                Console.Write("What gamemode do you want to play? ");
                gameMode = Convert.ToInt32(Console.ReadLine());
                switch (gameMode)
                {
                    case 1:
                        Console.Write("I want to play best of ");
                        bestOf = Convert.ToInt32(Console.ReadLine());
                        validGameMode = true;
                        break;
                    case 2:
                        Console.Write("I want to play first to ");
                        maxScoreCount = Convert.ToInt32(Console.ReadLine());
                        validGameMode = true;
                        break;
                    case 3:
                        Console.WriteLine("You chose endless game mode");
                        maxScoreCount = 99;
                        validGameMode = true;
                        break;
                    default:
                        Console.WriteLine("Invalid gamemode choice!");
                        break;
                }
            }

            //0 Rock
            //1 Paper
            //2 Scissors


            //turn
            while (gameContinues)
            {
                Console.Write("Write Rock, Paper of Scissors: ");
                playerInput = Console.ReadLine();

                if (playerInput == "Rock" || playerInput == "rock")
                {
                    switch (cpuInput)
                    {
                        case 0:
                            Console.WriteLine("The computer chose Rock");
                            Console.WriteLine("Draw!");

                            break;
                        case 1:
                            Console.WriteLine("The computer chose Paper");
                            Console.WriteLine("You lose!");
                            cpuScore++;
                            break;
                        case 2:
                            Console.WriteLine("The computer chose Scissors");
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
                else if (playerInput == "Paper" || playerInput == "paper")
                {
                    switch (cpuInput)
                    {
                        case 0:
                            Console.WriteLine("The computer chose Rock");
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        case 1:
                            Console.WriteLine("The computer chose Paper");
                            Console.WriteLine("Draw!");
                            break;
                        case 2:
                            Console.WriteLine("The computer chose Scissors");
                            Console.WriteLine("You lose!");
                            cpuScore++;
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
                else if (playerInput == "Scissors" || playerInput == "scissors")
                {
                    switch (cpuInput)
                    {
                        case 0:
                            Console.WriteLine("The computer chose Rock");
                            Console.WriteLine("You lose!");
                            cpuScore++;
                            break;
                        case 1:
                            Console.WriteLine("The computer chose Paper");
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        case 2:
                            Console.WriteLine("The computer chose Scissors");
                            Console.WriteLine("Draw!");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                gameCount++;
                Console.WriteLine("You - " + playerScore + " Computer - " + cpuScore);

                //checks if game is done
                switch (gameMode)
                {
                    case 1:
                        if (bestOf == gameCount)
                        {
                            gameContinues = false;
                        }
                        break;
                    case 2:
                        if (maxScoreCount == cpuScore)
                        {
                            gameContinues = false;
                        }
                        else if (maxScoreCount == playerScore)
                        {
                            gameContinues = false;
                        }
                        break;
                    case 3:
                        if (maxScoreCount == cpuScore)
                        {
                            gameContinues = false;
                        }
                        else if (maxScoreCount == playerScore)
                        {
                            gameContinues = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown Error");
                        break;
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }

            //after game ended
            if (cpuScore > playerScore)
            {
                Console.WriteLine("You lost!");
            }
            else if (playerScore > cpuScore)
            {
                Console.WriteLine("You Win!");
            }
            else if(playerScore == cpuScore)
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadLine();



        }
    }
}