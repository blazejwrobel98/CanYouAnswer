using System;
using System.IO;
using System.Linq;

namespace Repository
{
    public class Input
    {
        static bool GetInt(string line = "")
        {
            if (int.TryParse(line, out int res))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Menu()
        {
            while (true)
            {
                int counter = 1;
                foreach (string el in Storage.Menu_options.Main())
                {
                    if (el == "Wyjście")
                    {
                        counter = 0;
                    }
                    Console.WriteLine($"[{counter}] {el}");
                    counter++;
                }
                string text = Console.ReadLine();
                if (Repository.Input.GetInt(text))
                {
                    return (int.Parse(text));
                }
                else
                {
                    Console.WriteLine("Wpisana wartość nie jest liczbą");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
        public static string GetName()
        {
            while (true)
            {
                Console.Write("Podaj nick: ");
                string temp = Console.ReadLine();
                string[] players = Storage.Players.List();
                int counter = players.Length;
                if (players.Contains(temp))
                {
                    Console.WriteLine("Taki użytkownik już istnieje, chcesz wybrać istniejącego czy stworzyć nowego?");
                    Console.WriteLine("[0] Istniejący \n[1] Nowy");
                    string choose = Console.ReadLine();
                    if (GetInt(choose))
                    {
                        int choice = int.Parse(choose);
                        switch (choice)
                        {
                            case 0:
                                return temp;
                            case 1:
                                continue;
                        }
                    }
                    Console.Clear();
                }
                else
                {
                    if (counter > 0)
                    {
                        File.AppendAllText(@"../../../db/users.txt", Environment.NewLine + $"{temp}" );
                    }
                    else
                    {
                        File.AppendAllText(@"../../../db/users.txt", $"{temp}");
                    }
                    return temp;
                }
                Console.Clear();
            }
        }
    }
    public class Player
    {
        private string name;
        private string level;
        private string score;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        public string Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
