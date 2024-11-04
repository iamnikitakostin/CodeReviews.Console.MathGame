namespace MathGame.Menu
{
    public class Menu
    {
        private readonly List<string> _history;
        public int difficultyLevel = 3;
        public int operation = 1;

        public Menu(List<string> history)
        {
            _history = history;
        }

        public async Task GetMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("S - Start Playing");
                Console.WriteLine("H - History");
                Console.WriteLine("L - Select Difficulty Level");
                Console.WriteLine("O - Select Operation");
                Console.WriteLine("C - Credits");

                string userInput = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("You probably entered a wrong operation, or entered nothing.");
                    continue;
                }

                switch (userInput.ToUpper())
                {
                    case "S":
                        Gameplay.Game.StartGame(_history, operation, difficultyLevel);
                        break;
                    case "H":
                        await History.History.GetHistory(_history);
                        break;
                    case "L":
                        difficultyLevel = DifficultyLevel.DifficultyLevel.ChangeDifficultyLevel();
                        break;
                    case "O":
                        operation = OperationChanger.OperationChanger.OperatorChanger();
                        break;
                    case "C":
                        Credits.Credits.GetCredits();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please, try again.");
                        continue;
                }
            }
        }
    }
}
