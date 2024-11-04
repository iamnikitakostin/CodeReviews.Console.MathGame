namespace MathGame.Credits
{
    internal class Credits
    {
        static public void GetCredits()
        {
            var credits = new List<string>();
            credits.Add("Created by Nikita Kostin.\n");
            credits.ForEach(i => Console.Write(i));
        }
    }
}
