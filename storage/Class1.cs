using System.IO;
using System.Linq;

namespace Storage
{
    public class Questions
    {
        public static string[] List()
        {
            string[] questions = File.ReadLines("../../../questions/questions.txt").ToArray();
            return questions;
        }
    }
    public class Menu_options
    {
        public static string[] Main()
        {
            var options = new string[] { "Graj", "Instrukcja", "Statystyki", "Opcje", "Wyjście" };
            return options;
        }
    }
    public class Players
    {
        public static string[] List()
        {
            string[] players = File.ReadLines("../../../db/users.txt").ToArray();
            return players;
        }
    }
}
