using System;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            Console.WriteLine(str + "\n");
            string[] words = str.Split(' ');
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n");
            Array.Sort(words);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n");
            string s = string.Join(" ", words);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
