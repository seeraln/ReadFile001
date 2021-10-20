using System;
using System.IO;

namespace ReadFile001
{
    class Program
    {
        static void Main(string[] args)
        {
           // FileDemo.ReadDemo("jamaica.txt");
            string dc_heroesFile = "dc-heroes.txt";
            string[] dc_heroes = { "Batman: Bruce Wayne", "Flash : jean ", "Martian Manhunter: pierre" };
            FileDemo.WriteDemo(dc_heroesFile, dc_heroes);
            FileDemo.ReadAndParseString(dc_heroesFile);

            FileDemo.OutputSep();


            string marvel_heroesFile = " marvel-heroes.txt";
            string[] marvel_heroes = { "Iron-Man: Tony Stark", "Hulk:Bruce Banner", "Thor: Thor" };
            FileDemo.WriteDemo(marvel_heroesFile, marvel_heroes);
            FileDemo.ReadAndParseString(marvel_heroesFile);

            char[] characters = FileDemo.SplitAString("supercalifragilisticexpialidocious");
            Console.WriteLine($"The character at position 11 is {characters[10]}");
        }
    }
}
