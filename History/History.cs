namespace MathGame.History
{
    internal class History
    {
        public static async Task GetHistory(List<string> history) {
            history.ForEach(i => Console.WriteLine(i));
        }
    }
}
