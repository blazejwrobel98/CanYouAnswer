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
                        Console.Clear();
                        Settings();
                        break;
                    case 0:
                        Console.WriteLine("Zamykam program");
                        return;
                    default:
                        Console.WriteLine("Nie wybrano żadnej z powyższych opcji, spróbuj jeszcze raz");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.Clear();
            }
        }
        public static void Start_game()
        {
            if (gamer.Name!=null)
            {
                Console.WriteLine("Gramy!");
                Console.ReadKey();
                Console.Clear();
                Repository.Input.Question();
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
                Console.ReadKey();
                Console.Clear();
                return;
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Wybierz opcję z dostępnych:\n[0] Zmiana użytkownika\n[1] Wyloguj się\n[2] Wróć");
                    string temp = Console.ReadLine();
                    if (Repository.Input.GetInt(temp))
                    {
                            switch (int.Parse(temp))
                            {
                                case 0:
                                    gamer.Name = Repository.Input.GetName();
                                    Console.WriteLine($"Witaj {gamer.Name}");
                                    Console.ReadKey();
                                Console.Clear();
                                return;
                                case 1:
                                    gamer.Name = null;
                                    Console.WriteLine("Wylogowano");
                                    Console.ReadKey();
                                Console.Clear();
                                return;
                                case 2:
                                    return;
                                default:
                                    Console.WriteLine("Nie wybrano żadnej z powyższych opcji, spróbuj jeszcze raz");
                                    Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                    }
                    else
                    {
                        Console.WriteLine("Wpisana wartość nie jest liczbą");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
