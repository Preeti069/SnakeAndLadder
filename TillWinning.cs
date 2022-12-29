using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderProblem
{
    public class TillWinning
    {
        public static void TillPosition100()
        {
              int PlayerPosition = 0;

              Random random = new Random();

                while (PlayerPosition < 100)
                {
                    int Roll_die = random.Next(1, 7);
                    int Option = random.Next(3);

                    PlayerPosition += Roll_die;

                    if (Option == 0)
                    {
                        PlayerPosition = PlayerPosition - Roll_die;
                        Console.WriteLine("snake " + PlayerPosition);
                    }
                    else if (Option == 1)
                    {
                        PlayerPosition = PlayerPosition + Roll_die;
                        Console.WriteLine("ladder " + PlayerPosition);
                    }
                    else
                    {
                        Console.WriteLine("no play " + PlayerPosition);
                    }

                    if (PlayerPosition > 100) PlayerPosition -= Roll_die;
                    if (PlayerPosition < 0) PlayerPosition = 0;

                    if (PlayerPosition == 100) Console.WriteLine("player has won");
                }
        }
    }
}
