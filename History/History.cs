using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.History
{
    internal class History
    {
        public static async Task GetHistory(List<string> history) {
            history.ForEach(i => Console.WriteLine(i));
        }
    }
}
