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
            Console.WriteLine("===============================================================");
            Console.WriteLine("===============================================================");
            Console.ReadLine();

            int countingLines = System.IO.File.ReadLines(@"U: \Users\732160\peterWeek6\peter week6\Beowulf.txt").Count();
            Console.WriteLine("Total number of lines in the text is "+countingLines);
            Console.WriteLine("===============================================================");
            Console.ReadLine();

            int wordCount = beowulfTxt.Split().Length;
            Console.WriteLine("Toal number of words in the text file is "+wordCount);
            Console.WriteLine("===============================================================");
            Console.ReadLine();

            int characterCount = beowulfTxt.Length;
            Console.WriteLine("Toal number of letters in the text file is " + characterCount);
            Console.WriteLine("===============================================================");
            Console.ReadLine();

            double lPerWord;
            lPerWord = (double)characterCount / (double)wordCount;
            Console.WriteLine("Average number of letters per word is " + lPerWord);
            Console.WriteLine("===============================================================");
            Console.ReadLine();
        }
    }
}
