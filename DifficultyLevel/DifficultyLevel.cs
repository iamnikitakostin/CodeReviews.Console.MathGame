using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.DifficultyLevel
{
    internal class DifficultyLevel
    {
        public static int ChangeDifficultyLevel()
        {
            Console.WriteLine("Please, choose the difficulty level: 1/2/3");
            string level = Console.ReadLine();
            if (level != null) { 
                if (level == "1")
                {
                    return 1;
                } else if (level == "2")
                {
                    return 2;
                } else if (level == "3")
                {
                    return 3;
                }
            }
            Console.WriteLine("Incorrect input. The level set to 1.");
            return 1;
        }
    }
}
