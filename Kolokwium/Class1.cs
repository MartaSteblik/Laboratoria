﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] tab = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            QuickSort(tab, 3, 14);
            foreach (var item in tab)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static int j;

        public static void QuickSort(int[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = array[(left + right) / 2];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    var tmp = array[i];
                    array[i++] = array[j];
                    array[j--] = tmp;
                }
                {
                    if (left < j) QuickSort(array, left, j);
                    if (i < right) QuickSort(array, i, right);
                }
            }
        }
    }
}
