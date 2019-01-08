using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Searching
    {
        public static object BinarySearch<T>( T element, IList<T> collection) where T: IComparable
        {
            var firstIndex = 0;
            var lastIndex = collection.Count - 1;

            while (firstIndex < lastIndex)
            {
                var middleOndex = (firstIndex + lastIndex) / 2;
                if (collection[middleOndex].CompareTo(element) == 0)
                {
                    return collection[middleOndex];
                }
                else if (element.CompareTo(collection[middleOndex]) == -1)
                {
                    lastIndex = middleOndex - 1;
                }
                else if(element.CompareTo(collection[middleOndex]) == 1)
                {
                    firstIndex = middleOndex + 1;
                }
            }
            return "None";

            
        }
    }
}
