namespace MathGame.History
{
    internal class History
    {
        public static async Task GetHistory(List<string> history) {
            history.ForEach(i => Console.WriteLine(i));
            Console.Write("Press any key to go back to the main menu...");
            Console.ReadKey();
        }
    }
}
