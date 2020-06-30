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
            try
            {
                Start.Menu();
            }
            catch
            {
                throw new Exception("Wystąpił błąd w [Start.Menu()]");
            }
            
        }
    }
    class Start
    {
        public static void Menu()
        {
            while (true)
            {
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
                        game.RandomQuestion();
                        break;
                }
            }
        }
    }
}
