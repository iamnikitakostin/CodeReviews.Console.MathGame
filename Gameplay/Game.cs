using System.Diagnostics;

namespace MathGame.Gameplay
{
    internal class Game
    {
        public static async void StartGame(List<string> history, int operation, int difficultyLevel)
        {
            Stopwatch stopWatch = new Stopwatch();
            int initialOp = operation;

            // Operation legend:
            // 1 - Multiply
            // 2 - Divide
            // 3 - Substract
            // 4 - Sum
            // 5 - Random

            while (true) {
                if (initialOp == 5)
                {
                    Console.WriteLine("Generating a new operation...");
                    Random randomOp = new Random();
                    string[] operators = { "*", "/", "-", "+" };
                    int index = randomOp.Next(operators.Length);
                    operation = index + 1;
                }
                int[] numbers = RandomNumber.RandomNumber.GetNumber(operation, difficultyLevel);
                string operationString;
                int result;

                switch (operation)
                {
                    case 1:
                        operationString = "*";
                        result = numbers[0] * numbers[1];
                        break;
                    case 2:
                        operationString = "/";
                        result = numbers[0] / numbers[1];
                        break;
                    case 3:
                        operationString = "-";
                        result = numbers[0] - numbers[1];
                        break;
                    case 4:
                        operationString = "+";
                        result = numbers[0] + numbers[1];
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        continue;
                }

                
                Console.WriteLine($"Here is the challenge: {numbers[0]} {operationString} {numbers[1]}.\nAnswer here:");
                stopWatch.Start();
                string answer = Console.ReadLine();
                if (answer != null)
                {
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    string elapsedTime = System.String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                      ts.Hours, ts.Minutes, ts.Seconds,
                      ts.Milliseconds / 10);
                    answer = answer.Trim();
                    int userAnswer;
                    bool isValidInput = int.TryParse(answer, out userAnswer);
                    if (isValidInput && userAnswer == result)
                    {
                        Console.WriteLine("Congrats, you were right!");
                        history.Add($"{numbers[0]} {operationString} {numbers[1]}\t{elapsedTime}\t{answer}\t\t{result}\t\tWon");
                    }
                    else if (isValidInput && userAnswer != result)
                    {
                        Console.WriteLine("You were wrong. Nice try, keep on going!");
                        history.Add($"{numbers[0]} {operationString} {numbers[1]}\t{elapsedTime}\t{answer}\t\t{result}\t\tLost");
                    } else
                    {
                        Console.WriteLine("Your input contained unrecognizable number(s). The question will be skipped.");
                    }
                    Console.WriteLine("Press K to keep going, or Press Q to quit to the main menu.");
                    string userChoice = Console.ReadLine()!.ToUpper();
                    if (userChoice == "K")
                    {
                        continue;
                    }
                    else if (userChoice == "Q")
                    {
                        break;
                    } else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please, enter the response again: ");
                }
            }
           


        }
    }
}
