using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using storage;

namespace CanYouAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            Start.Menu();
        }
    }
    class Start
    {
        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                int counter = 1;
                foreach (string el in storage.menu_options.main())
                {
                    if (el == "Wyjście")
                    {
                    counter = 0;
                    }
                    Console.WriteLine($"[{counter}] {el}");
                    counter++;
                }
                int choose = ClassLibrary1.input.GetInt();
                switch (choose)
                {
                    case 1:
                        Game.Start();
                        break;
                    case 2:
                        Game.Manual();
                        break;
                    case 3:
                        Game.Statistics();
                        break;
                    case 4:
                        Game.Options();
                        break;
                    case 0:
                        Console.WriteLine("Zamykam program");
                        return;
                    default:
                        Console.WriteLine("Nie wybrano żadnej z powyższych opcji, spróbuj jeszcze raz");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
    class Game
    {
        public static void Start()
        {

        }
        public static void Manual()
        {

        }
        public static void Statistics()
        {

        }
        public static void Options()
        {

        }
    }
}
