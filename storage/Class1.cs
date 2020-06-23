using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage
{
    public class questions
    {
        List<string[]> main = new List<string[]>();
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
