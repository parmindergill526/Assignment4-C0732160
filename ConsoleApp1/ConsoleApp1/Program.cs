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
            Console.WriteLine("==============================Hit Enter=================================");
            Console.ReadLine();

            int countingLines = System.IO.File.ReadLines(@"U: \Users\732160\peterWeek6\peter week6\Beowulf.txt").Count();
            Console.WriteLine("Total number of lines in the text is "+countingLines);
            Console.WriteLine("===============================Hit Enter================================");
            Console.ReadLine();

            int wordCount = beowulfTxt.Split().Length;
            Console.WriteLine("Toal number of words in the text file is "+wordCount);
            Console.WriteLine("==============================Hit Enter=================================");
            Console.ReadLine();

            int characterCount = beowulfTxt.Length;
            Console.WriteLine("Toal number of letters in the text file is " + characterCount);
            Console.WriteLine("===============================Hit Enter================================");
            Console.ReadLine();

            double lPerWord;
            lPerWord = (double)characterCount / (double)wordCount;
            Console.WriteLine("Average number of letters per word is " + lPerWord);
            Console.WriteLine("===============================Hit Enter================================");
            Console.ReadLine();

            string [] beowulfTxtArray = System.IO.File.ReadAllLines(@"U: \Users\732160\peterWeek6\peter week6\Beowulf.txt");
            int lineCount = 0;

            for (int i =1; i < beowulfTxtArray.Length; i++)
            {
                if (beowulfTxtArray[i].ToUpper().Contains("SEA") && beowulfTxtArray[i].ToUpper().Contains("FARE"))
                {
                    lineCount++;
                }
            }
            Console.WriteLine("Toal number of lines that contains word --Sea-- and --Fare-- " + lineCount);
            Console.WriteLine("==============================Hit Enter=================================");
            Console.ReadLine();

            int lineCount2 = 0;
            for (int i = 1; i < beowulfTxtArray.Length; i++)
            {
                if (beowulfTxtArray[i].ToUpper().Contains("FARE") && !beowulfTxtArray[i].ToUpper().Contains("WAR"))
                {
                    lineCount2++;
                }
            }
            Console.WriteLine("Toal number of lines that contains word --Sea-- and not --War-- " + lineCount2);
            Console.WriteLine("==============================Hit Enter=================================");
            Console.ReadLine();
        }
    }
}
