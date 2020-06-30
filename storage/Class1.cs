using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage
{
    public class questions
    {
        public static string[] ReadQuestions()
        {
            string line;
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"..\..\..\questions\Chleb i wino.txt",Encoding.UTF8);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }
            file.Close();
            return line.Split(';');
        }
    }
    public class menu_options
    {
        public static string[] main()
        {
            var options = new string[] { "Graj" , "Instrukcja" , "Statystyki" , "Opcje" , "Wyjście" };
            return options;
        }
    }
}
