using System;
using System.Text;

namespace ConvertTimeString
{
    class Program
    {
        //Covert a string in AM/PM format to 24 hour time
        // 1:00pm = 1300
        // 12:00am = 0000
        // 10:00am = 1000
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("INPUT A TIME IN 0:00 AM/PM FORMAT. " +
                "THE FOLLOWING WILL COVERT " +
                "THE STRING FROM AM/PM TO 24HR TIME.");
            Console.Write("Input time: ");
            String OriginTime = Console.ReadLine();
            //Console.WriteLine(OriginTime);
            string[] OriginArrays = OriginTime.Split(new char[] { ':', ' ' }, 3);

            getTime(OriginArrays);
         
        }

        private static void getTime(string [] OriginArrays)
        {
            if (OriginArrays[0] == "12" && OriginArrays[2] == "am")
            {
                Console.WriteLine("0000");
            }
            else if (OriginArrays[0] == "12" && OriginArrays[2] == "pm")
            {
                Console.WriteLine($"12{OriginArrays[1]}");
            }
            else if (OriginArrays[0] != "12" && OriginArrays[2] == "pm")
            {
                int check = int.Parse(OriginArrays[0]);
                check += 12;
                Console.WriteLine($"{check + OriginArrays[1]}");
            }
            else if (OriginArrays[0] != "12" && OriginArrays[2] == "am")
            {
                int check = int.Parse(OriginArrays[0]);
                if (check < 10)
                    Console.WriteLine($"0{OriginArrays[0] + OriginArrays[1]}");
                else
                    Console.WriteLine($"{OriginArrays[0] + OriginArrays[1]}");
            }
        }
    }
}
