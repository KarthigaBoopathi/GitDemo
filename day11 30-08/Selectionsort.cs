using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_30_08
{
    internal class Selectionsort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            int n = 10;
            Console.WriteLine("Selection sort");
            Console.Write("\n Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
                Console.ReadLine();
            }
        }
    }
}
