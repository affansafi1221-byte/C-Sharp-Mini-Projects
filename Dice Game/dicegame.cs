using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace C_Sharp_Mini_Projects.Dice_Game
{
    internal class dicegame
    { 
        static void Main(string[]args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Press any key to roll the  dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine(" you rolled a " + playerRandomNum);

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI Rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine(" Player wins this round");


                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy Wins this round");

                }
                else
                {
                    Console.WriteLine("Draw match ");
                }


                

                    
            }
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine(" you Wins");

            }

            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine(" Enemy Wins");

            }
            else
            {
                Console.WriteLine(" Draw match");
            }
        }

    
    }
}
