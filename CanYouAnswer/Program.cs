using Repository;
using System;

namespace CanYouAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Options();
        }
    }
    class Game
    {
        public static Player gamer = new Player();
        public static void Options()
        {
            while (true)
            {
                int choose = Repository.Input.Menu();
                switch (choose)
                {
                    case 1:
                        Start_game();
                        break;
                    case 2:
                        Manual();
                        break;
                    case 3:
                        Statistics();
                        break;
                    case 4:
                        Settings();
                        break;
                    case 0:
                        Console.WriteLine("Zamykam program");
                        return;
                    default:
                        Console.WriteLine("Nie wybrano żadnej z powyższych opcji, spróbuj jeszcze raz");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }
        public static void Start_game()
        {
            if (gamer.Name!=null)
            {
                Console.WriteLine("Gramy");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nie rozpoznano użytkownika");
                Settings();
            }
        }
        public static void Manual()
        {

        }
        public static void Statistics()
        {

        }
        public static void Settings()
        {
            if (gamer.Name == null)
            {
                gamer.Name = Repository.Input.GetName();
                Console.WriteLine($"Witaj {gamer.Name}");
            }
        }
    }
}
