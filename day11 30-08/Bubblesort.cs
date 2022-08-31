using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_30_08
{
    internal class Bubblesort
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            Console.WriteLine("Original Elements:");
            foreach (var item in arr)
            {
                Console.WriteLine(" " + item);
            }
                Console.WriteLine();
            
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted elements:");
            foreach (int p in arr)
                Console.WriteLine(p + " ");
            Console.ReadLine();
        }
    }
}
