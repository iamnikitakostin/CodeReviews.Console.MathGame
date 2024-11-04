using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.RandomNumber
{
    internal class RandomNumber
    {
        private static readonly Random random = new();
        public static int[] GetNumber(int operation, int difficultyLevel)
        {
            int[] numbers;
            if (operation == 2)
            {
                int firstNumber = random.Next(1, (difficultyLevel * 50));
                int secondNumber = random.Next(1, firstNumber);
                while (firstNumber % secondNumber != 0)
                {
                    secondNumber = random.Next(1, firstNumber);
                }

                numbers = [firstNumber, secondNumber];
            }
            else
            {
                int firstNumber = random.Next(1, (difficultyLevel * difficultyLevel * 33));
                int secondNumber = random.Next(1, (difficultyLevel * difficultyLevel * 33));
                numbers = [firstNumber, secondNumber];
            }
            return numbers;
        }
    }
}
