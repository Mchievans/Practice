using System;

namespace LongestWordInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the longs word in a string or sentence
            //To test change string b to console readline 

            string a = "hello word";

            string b = "big baddddd bone";

            string[] splitter = b.Split(' ');
            int G = 0;
            string p = "a";

            foreach (var x in splitter)
            {
                if (x.Length > G)
                {
                    G = x.Length;
                    p = x;
                }

            }
            Console.WriteLine(p);
            Console.WriteLine(G);
        }
    }
}
