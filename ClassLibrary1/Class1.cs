using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using storage;

namespace ClassLibrary1
{
    public class menu
    {
        public static void Main(){
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
                int choose = input.GetInt();
            }
        }
    }
    public class input
    {
        public static int GetInt(string line="")
        {
            while (true)
            {
                if (line != "")
                {
                    Console.WriteLine(line);
                }
                string temp = Console.ReadLine();
                if (int.TryParse(temp, out int x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłową wartość, spróbuj jeszcze raz.");
                }
            }
        }
    }
}
