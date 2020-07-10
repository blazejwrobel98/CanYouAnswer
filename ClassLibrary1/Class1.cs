using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
    public class Input
    {
        public static bool GetInt(string line = "")
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
                if (temp.Trim() == "")
                {
                    Console.WriteLine("Nie podano żadnych danych");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
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
                            File.AppendAllText(@"../../../db/users.txt", Environment.NewLine + $"{temp}");
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
        public static int Question()
        {
            string[] questions = Storage.Questions.List();
            int counter = questions.Length;
            var random = new Random();
            int result = random.Next(0, counter-1);
            var gen = new List<string>();
            string[] que = questions[result].Split(';');
            foreach(string el in que)
            {
                gen.Add(el.Trim(';'));
            }
            string[] res = gen.ToArray();
            var rnd = new Random();
            int rand = rnd.Next(1, 4);
            string odp1 = null;
            string odp2 = null;
            string odp3 = null;
            string odp4 = null;
            switch (rand)
            {
                case 1:
                    odp1 = res[1];
                    odp2 = res[2];
                    odp3 = res[3];
                    odp4 = res[4];
                    break;
                case 2:
                    odp1 = res[2];
                    odp2 = res[1];
                    odp3 = res[4];
                    odp4 = res[3];
                    break;
                case 3:
                    odp1 = res[4];
                    odp2 = res[2];
                    odp3 = res[1];
                    odp4 = res[3];
                    break;
                case 4:
                    odp1 = res[2];
                    odp2 = res[4];
                    odp3 = res[3];
                    odp4 = res[1];
                    break;
            }
            Console.WriteLine($"{res[0]}\n[1]{odp1}\t[2]{odp2}\t[3]{odp3}\t[4]{odp4}\t");
            Console.WriteLine("\n\nJeżeli chcesz zakończyć grę wciśnij ENTER");
            string answer = Console.ReadLine();
            if (GetInt(answer))
            {
                int choose = int.Parse(answer);
                switch (rand)
                {
                    case 1:
                        if(choose == 1)
                        {
                            Console.WriteLine("Odpowiedź poprawna!!");
                            Console.ReadKey();
                            return 1;
                        }
                        else
                        {
                            Console.WriteLine("Błędna odpowiedź!!");
                            Console.ReadKey();
                            return 0;
                        }
                    case 2:
                        if (choose == 2)
                        {
                            Console.WriteLine("Odpowiedź poprawna!!");
                            Console.ReadKey();
                            return 1;
                        }
                        else
                        {
                            Console.WriteLine("Błędna odpowiedź!!");
                            Console.ReadKey();
                            return 0;
                        }
                    case 3:
                        if (choose == 3)
                        {
                            Console.WriteLine("Odpowiedź poprawna!!");
                            Console.ReadKey();
                            return 1;
                        }
                        else
                        {
                            Console.WriteLine("Błędna odpowiedź!!");
                            Console.ReadKey();
                            return 0;
                        }
                    case 4:
                        if (choose == 4)
                        {
                            Console.WriteLine("Odpowiedź poprawna!!");
                            Console.ReadKey();
                            return 1;
                        }
                        else
                        {
                            Console.WriteLine("Błędna odpowiedź!!");
                            Console.ReadKey();
                            return 0;
                        }
                }
            }
            else
            {
                if (answer == "")
                {
                    Console.WriteLine("Koniec gry");
                    Console.ReadKey();
                    return 2;
                }
                else
                {
                    Console.WriteLine("Błędne dane!");
                    Console.ReadKey();
                }
            }
            return 0;
        }
        public static void Score(Player gamer)
        {
            Console.WriteLine($"W  bieżącej sesji uzyskałeś wynik: {gamer.Score}");
            if (gamer.Score > 0)
            {
                Console.WriteLine($"Gratulacje {gamer.Name}!");
            }
            Console.ReadKey();
        }
    }
    public class Player
    {
        private string name;
        private int score=0;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
