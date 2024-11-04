namespace MathGame.OperationChanger
{
    internal class OperationChanger
    {
        static public int OperatorChanger()
        {
            while (true) {
                Console.WriteLine("Choose the operation you want to play:\n1 - Multiply\n2 - Divide\n3 - Substract\n4 - Sum\n5 - Random");
                string input = Console.ReadLine();
                int answer;
                bool isValidInput = int.TryParse(input, out answer);
                if (isValidInput && (answer > 0 && answer < 6))
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number between 1 and 5.");
                    continue;
                }
            }
        }
    }
}
