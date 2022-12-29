using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderProblem
{
    public class RollsDie
    {
        public static void Rolls()
        {
            int position = 0;
            Console.WriteLine("Start Positon is : " + position);
            Random random = new Random();
            int dicethrown = random.Next(1, 7);
            Console.WriteLine("\n Dies Output is : " + dicethrown);
        }
    }
}
