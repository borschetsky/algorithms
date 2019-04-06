using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creatig of classic array
            int[] array = new int[] { 5, 1, 10, 2, 9, 3, 7, 4, 6, 8 };
            //int[] array = new int[] { 2, 1 };

            //creating of dynamic array and adding values from classic arr
            //List<int> arr = new List<int>(array);
            //Testin Insertion Sort method with collections from type IList<T> where T : IComparable
            //Sorting.InsertionSortByShifting(arr);
            //Sorting.InsertionSortBySwapping(array);
            //Sorting.SelectionSortBySwap(array);
            //Orinting result
            //array = Sorting.QuickSort(array).ToArray();
            //array = Sorting.MergeSort(array).ToArray();
            //Sorting.BubbleSort(array);
            Sorting.QuickSortClassic(array, 0, array.Length - 1);
            //var result = Searching.BinarySearch(11, array);
            //Console.WriteLine(result);
            PrintCollection(array);
            //Console.WriteLine(Searching.BinarySearch(1, array, 0, array.Length - 1));
            //TEST



        }

        private static void PrintCollection<T>(IList<T> collection) 
        {
            Console.WriteLine(string.Join(", ", collection.ToArray()));
        }
    }
}
