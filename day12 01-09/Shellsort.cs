﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_30_08
{
    internal class Shellsort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {90,78,56,89,70,-98,45,23,9};
            int n;

            n = arr.Length;
            Console.WriteLine("Original Array Elements :");
            show_array_elements(arr);
            shellSort(arr, n);
            Console.WriteLine("\n Sorted Array Elements :");
            show_array_elements(arr);
        }

        static void shellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        static void show_array_elements(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
            Console.ReadLine();

        }
    }
}
