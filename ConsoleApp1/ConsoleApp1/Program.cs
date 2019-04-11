using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string beowulfTxt = System.IO.File.ReadAllText(@"U: \Users\732160\peterWeek6\peter week6\Beowulf.txt");
            Console.WriteLine(beowulfTxt);
            Console.ReadLine();
        }
    }
}
