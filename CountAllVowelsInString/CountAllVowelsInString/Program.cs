using System;

namespace CountAllVowelsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = "milk monsters making moves";
            char [] vowels = new char [] {'A','E','I','O','U','a','e','i','o','u'};
            int count = 0;

            for ( int i = 0; i < B.Length; i ++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (B[i] == vowels[j])
                        count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
