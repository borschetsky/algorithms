using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Searching
    {
        public static object BinarySearch<T>( T element, IList<T> collection) where T:  IComparable
        {
            var firstIndex = 0;
            var lastIndex = collection.Count - 1;

            while (firstIndex <= lastIndex)
            {
                var middleIndex = (firstIndex + lastIndex) / 2;
                if (collection[middleIndex].CompareTo(element) == 0)
                {
                    return collection[middleIndex];
                }
                else if (element.CompareTo(collection[middleIndex]) == -1)
                {
                    lastIndex = middleIndex - 1;
                }
                else if(element.CompareTo(collection[middleIndex]) == 1)
                {
                    firstIndex = middleIndex + 1;
                }
            }
            
            return "None";
        }

        public static object BinarySearch<T> (T key, IList<T> arr, int left, int right) where T : IComparable
        {
            if (left > right)
            {
                return "None";
            }
            else
            {
                int mid = (left + right) / 2;
                if (arr[mid].CompareTo(key) == 0)
                {
                    return arr[mid];
                }
                else if (arr[mid].CompareTo(key) == -1)
                {
                    return BinarySearch(key, arr, mid + 1, right);
                }
                else
                {
                    return BinarySearch(key, arr, left, mid - 1);
                }
            }
            
        }
    }
}
