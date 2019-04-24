using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 9, 3, 8, 2, 5, 1, 4, 7, 6, 10 };
            int holder = 0;
            int index = 0; 
            for (int i = 0; i < arr1.Length; i++)
            {
                int small = arr1[i];
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[j] < small)
                    {
                        small = arr1[j];
                        index = j;
                    }
                }
                holder = arr1[i];
                arr1[i] = small;
                arr1[index] = holder;
                Console.Write($"{arr1[i]},");
            }
        }
    }
}
