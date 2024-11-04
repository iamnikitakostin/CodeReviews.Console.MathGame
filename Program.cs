using System;
using MathGame.Gameplay;
using MathGame.Menu;

namespace MathGame
{
    public class MathGame
    {
        public static async Task Main() {
            List<string> history = new List<string> { "Challenge\tElapsed Time\tYour Answer\tCorrect Answer\tOutcome" };
            var menu = new Menu.Menu(history);
            await menu.GetMenu();
        }
    }
}


