using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchWithWhile();
        }

        static void BinarySearchWithWhile()
        {
            int[] array = { 22, 27, 33, 34, 56};
            int left = 0;
            int right = array.Length - 1;
            int target = 56;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                  right = mid - 1;
                }

            }
        }

        static void BinarySearchWithFor()
        {
            int[] array = { 22, 27, 33, 34, 56 };
            int right = array.Length - 1;
            int target = 56;

            for (int i = 0; i < right;)
            {
                int mid = (i + right) / 2;
                if (array[mid] == target)
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if(mid < target)
                {
                    i = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
    }
}
