using System;

namespace SimpleDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNumber;
            int enemyRandomNumber;
            int quantityWins = 0;
            int quantityLoses = 0;
            int quantityDraws = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("> Press any key to roll the dice <");

                Console.ReadKey();

                playerRandomNumber = random.Next(1, 7);
                Console.WriteLine(" = You rolled a " + playerRandomNumber);

                Console.WriteLine("Waiting enemy rolled... ");
                System.Threading.Thread.Sleep(1500);

                enemyRandomNumber = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNumber);

                if(playerRandomNumber > enemyRandomNumber) {
                    quantityWins++;
                    Console.WriteLine("You win !");
                } 
                else if(playerRandomNumber < enemyRandomNumber)
                {
                    quantityLoses++;
                    Console.WriteLine("You lose !");
                } 
                else
                {
                    quantityDraws++;
                    Console.WriteLine("You draw !");
                }
            }
            Console.WriteLine("--------------- GAME FINISHED ---------------");
            Console.WriteLine("Wins: " + quantityWins);
            Console.WriteLine("Loses: " + quantityLoses);
            Console.WriteLine("Draws : " + quantityDraws);
            Console.WriteLine("---------------------------------------------");

        }
    }
}