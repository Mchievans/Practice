using System.Collections.Generic;
using static SortWeightedString.Program;

namespace SortWeightedString
{
    class Program
    {

        static void Main(string[] args)
        {
            string alpha = "abbcccdddde";
            Dictionary<string,int> bravo = new Dictionary<string,int>();
            int j = 0;
            string m;
            foreach(char a in alpha)
            {
                m = a.ToString();
                if(bravo.ContainsKey(m))
                {
                    j++;
                    bravo.Add(m,j);
                }
                
            }
            foreach(KeyValuePair<string,int> k in bravo)
            {
                if(k.Key.CompareTo(k.Key) == 'a')
                {
                    System.Console.WriteLine(k.Key);
                }
            }

        }
    }
}

