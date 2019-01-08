using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Sorting
    {
        public static void InsertionSortByShifting<T>(IList<T> collection) where T : IComparable
        {
            for (int i = 1; i < collection.Count; i++)
            {
                var key = collection[i];
                var j = i - 1;
                while (j >= 0 && key.CompareTo(collection[j]) == -1)
                {
                    collection[j + 1] = collection[j];
                    j--;
                }
                collection[j + 1] = key;

            }
        }

        public static void InsertionSortBySwapping<T>(IList<T> collection) where T : IComparable
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (collection[j].CompareTo(collection[j - 1]) == -1)
                    {
                        //Swaping 

                        Swap(collection, j, j - 1);
                    }
                }
            }
        }

        public static void SelectionSortBySwap<T>(IList<T> collection) where T : IComparable
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                var smallestIndex = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[smallestIndex]) == -1)
                    {
                        smallestIndex = j;
                    }
                }
                //Swaping
                Swap(collection, i, smallestIndex);
            }
        }

        public static IList<T> QuickSort<T>(IList<T> collection) where T : IComparable
        {
            if (collection.Count < 2)
            {
                return collection;
            }
            var left = new List<T>();
            var right = new List<T>();
            int pivotIndex = (0 + collection.Count - 1) / 2;

            for (int i = 0; i < collection.Count; i++)
            {
                if (i == pivotIndex)
                {
                    continue;
                }
                if (collection[i].CompareTo(collection[pivotIndex]) == -1 
                    || collection[i].CompareTo(collection[pivotIndex]) == 0)
                {
                    left.Add(collection[i]);
                }
                else if (collection[i].CompareTo(collection[pivotIndex]) == 1)
                {
                    right.Add(collection[i]);
                }
            }
            var result = new List<T>();
            result.AddRange(QuickSort(left));
            result.Add(collection[pivotIndex]);
            result.AddRange(QuickSort(right));

            return result;

        }

        private static void Swap<T>(IList<T> array, int a, int b) where T : IComparable
        {
            var temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public static IList<T> MergeSort<T>(IList<T> collection) where T : IComparable
        {
            if (collection.Count < 2)
            {
                return collection;
            }
            var left = collection.Take(collection.Count / 2);
            var right = collection.Skip(collection.Count / 2);
            left = MergeSort(left.ToList());
            right = MergeSort(right.ToList());

            return Merge(left.ToList(), right.ToList());



        }

        private static IList<T> Merge<T>(IList<T> left, IList<T> right) where T : IComparable
        {
            int i = 0;
            int j = 0;
            var result = new List<T>();
            while (i < left.Count() && j < right.Count())
            {
                if (left[i].CompareTo(right[j]) == -1 || left[i].CompareTo(right[j]) == 0)
                {
                    result.Add(left[i]);
                    i++;
                }
                else if(left[i].CompareTo(right[j]) == 1)
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
            {
                result.Add(left[i]);
                i++;
            }
            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }

            return result;


        }
    }
}
