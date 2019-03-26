using System;

namespace CheckStringForSubString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input two words. If the second word is contained in the " +
                "first it will retrun the index of the first element in the first string." +
                " If it is not contained in the first string it will return -1");

            
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            string l = "mmmmmmfoodmmmmmnm";
            string s = "foooooood";
            int C = 0;
            int P = 0;

            char[] stringHolder = new char[B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {

                        stringHolder[j] = A[i];
                    }
                    else if (A[i] == B[0])
                    {
                        C = i;
                    }
                    
                }

            }
            //for (int x = 0; x < B.Length; x++)
            //{
            //    if (stringHolder[x] == B[x] && stringHolder.Length == B.Length)
            //        C *= 1;
            //    else if (x != B[x] )
            //        C = -1;
            //}
            if (C == 0)
                C += -1;
            Console.WriteLine(C);
        }

    }
}






