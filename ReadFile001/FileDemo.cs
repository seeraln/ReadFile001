using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ReadFile001
{
    class FileDemo
    {
        public static void ReadAndParseString(string file)
        {
            string path = "C:/Users/seera/OneDrive/Bureau/Ecole/A3/S5/Object oriented";
            //string file = "jamaica.txt";
            string fileToRead = $"{path}/{file}";

            Console.WriteLine($"Reading {fileToRead}");
            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {

                    //Console.WriteLine($"Starting to Reading {fileToRead}");

                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] splitData = line.Split(":");

                        Console.WriteLine($"\t{String.Format("{0,-30}", splitData[0])}\t{splitData[1]}");

                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

            }
        }

        public static void WriteDemo(string file, string[] heroes)
        {


            string path = "C:/Users/seera/OneDrive/Bureau/Ecole/A3/S5/Object oriented";
            // string file = "heroes.txt";
            string fileToWrite = $"{path}/{file}";

            using (StreamWriter sw = new StreamWriter(fileToWrite))
            {
                foreach (string s in heroes)
                {
                    sw.WriteLine(s);
                }

            }
            Console.WriteLine("done");
            Console.ReadKey();
        }

        public static char[]  SplitAString(string stringToSplit)
        {
            char[] characters = stringToSplit.ToCharArray();
            foreach(char c in characters)
            {
                Console.Write($"'{c}'");
            }
            Console.WriteLine("");
            return characters;
        }

        public static void OutputSep()
        {
            Console.WriteLine("=".PadRight(80, '='));
        }
       
    }
}
