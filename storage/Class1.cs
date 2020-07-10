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
    public class Manual
    {
        public static string[] List()
        {
            string[] manual = { "Menu wyświetlane po uruchomieniu steruje działaniem aplikacji",
                "Opcja graj zaczyna grę, jeśli nie zalogowaliśmy się w pozycji\n opcje to zostaniemy " +
                "przekierowani. Podczas gry należy wybierać \npoprawne odpowiedzi za pomocą cyfr 1-4 " +
                "i zatwierdzać klawiszem ENTER","W opcji statystyki możemy podejrzeć zebrane w sesji " +
                "punkty. \nWynik nie jest zapisywany i po restarcie zostanie utracony!!",
                "W sekcji Opcje możemy się Zalogować, Zmienić użytkownika bądź Wylogować",
                "Opcja Wyjście zamyka aplikację" };
            return manual;
        }
    }
}
