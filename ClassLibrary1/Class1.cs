using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using storage;

namespace ClassLibrary1
{
    
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
    public class game
    {
        public static int RandomQuestion()
        {
            string[] available = storage.questions.ReadQuestions();
            foreach(string el in available)
            {
                Console.WriteLine(el);
            }
            return 1;
        }
    }
}
