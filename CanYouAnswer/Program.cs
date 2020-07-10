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
                while (true)
                {
                    Console.Clear();
                    int score = Repository.Input.Question();
                    switch (score)
                    {
                        case 0:
                            continue;
                        case 1:
                            gamer.Score += 1;
                            continue;
                        case 2:
                            return;
                    }
                }
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
            string[] manual = Storage.Manual.List();
            int counter = 1;
            foreach(string el in manual)
            {
                Console.WriteLine($"[{counter}] {el}");
                counter++;
            }
            Console.ReadKey();
        }
        public static void Statistics()
        {
            Repository.Input.Score(gamer);
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
