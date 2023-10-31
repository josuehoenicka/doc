using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;   
            int enemyScore = 0;

            Console.WriteLine("Welcome to the Rock Paper Scissors Game !");
            Console.WriteLine("");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("Please enter 'r' for ROCK, 'p' for PAPER or anything else for SCISSORS");

                string playerSelection = Console.ReadLine();

                int enemySelection = random.Next(0, 3);

                if (enemySelection == 0)
                {
                    switch(playerSelection)
                    {
                        case "r":
                            Console.WriteLine("TIE (Enemy chooses ROCK)");
                            break;
                        case "p":
                            Console.WriteLine("YOU WIN (Enemy chooses ROCK)");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("YOU LOSE (Enemy chooses ROCK)");
                            enemyScore++;
                            break;
                    }
                } 
                else if(enemySelection == 1)
                {
                    switch (playerSelection)
                    {
                        case "p":
                            Console.WriteLine("TIE (Enemy chooses PAPER)");
                            break;
                        case "r":
                            Console.WriteLine("YOU WIN (Enemy chooses PAPER)");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("YOU LOSE (Enemy chooses PAPER)");
                            enemyScore++;
                            break;
                    }

                }
                else
                {
                    switch (playerSelection)
                    {
                            
                        case "p":
                            Console.WriteLine("YOU WIN (Enemy chooses SCISSORS)");
                            playerScore++;
                            break;
                        case "r":
                            Console.WriteLine("YOU LOSE (Enemy chooses SCISSORS)");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("TIE (Enemy chooses SCISSORS)");
                            break;
                    }
                }

            }
            if(playerScore == 3 || enemyScore == 3) {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("------------------------- GAME FINISHED ------------------------------");
                Console.WriteLine("WINS: " + playerScore);
                Console.WriteLine("LOSES: " + enemyScore);
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}