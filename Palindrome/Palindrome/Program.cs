using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Malachi";
            string racecar = "racecar";
            string tacocat = "tacocat";
            string banana = "yobananaboy";

            //bool reverse = reverseString(name);
            //bool reverse1 = reverseString(racecar);
            //string[] bust = name.Split(new char[] { ',' });
            //foreach (string m in bust)
            //{
            //    if (m != "")
            //    {
            //        Console.WriteLine(m);
            //    }
            //}
            //Console.WriteLine($"{reverse}, {reverse1}");


            for( int x = 0,j = racecar.Length-1; x < j; x++, j--)
            {
                if (banana[x] == banana[j])
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false); 
            }

        }

        private static bool reverseString(string n)
        {
            int len = n.Length;
            char[] r = new char[len];
            for (int i = 0, j = len - 1; i < len; i++, j--)
            {

                if (r[j] == n[i])
                    return true;
                else
                    return false;
            }
            string s = new string(r);
            return true;
        }
    }
}


