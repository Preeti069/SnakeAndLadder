using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To Snake And Ladder Program");
            //SnakeLadder.SinglePlayer();
            //RollsDie.Rolls();
            //ChecksForOption.SnakeLadder();
            //TillWinning.TillPosition100();
            //ExactWinning.Winning();
            //Position.DieCountTillWin();


            Console.WriteLine("Snake & Ladder Simulator");

            int PlayerPosition_1 = 0, PlayerPosition_2 = 0;


            Console.WriteLine("The Player has started from 0 possition");

            while (true)
            {
                PlayerPosition_1 = FinallyReport.mPlayerPosition(PlayerPosition_1);
                Console.WriteLine("player 1 position " + PlayerPosition_1);

                PlayerPosition_2 = FinallyReport.mPlayerPosition(PlayerPosition_2);
                Console.WriteLine("player 2 position " + PlayerPosition_2);
                if (PlayerPosition_1 == 100)
                {
                    Console.WriteLine("player 1 has won ");
                    break;
                }
                else if (PlayerPosition_2 == 100)
                {
                    Console.WriteLine("player 2 has won ");
                    break;
                }
            }

        }
    }
}
