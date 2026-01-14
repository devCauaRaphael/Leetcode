using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TwoSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MergeTwoSortedList();
        }

        static void MergeTwoSortedList()
        {
            int[] firstList = { 2, 4, 7, 13, 14, 22, 27 };
            int[] secondList = { 3, 6, 12, 21, 28, 43 };
            int j = 0;
            List<int> thirdList = new List<int>(); 
            for (int  i = 0; i < firstList.Length && j < secondList.Length;)
            {
                if (firstList[i] <= secondList[j])
                {
                    thirdList.Add(firstList[i]);
                    i++;
                }
                else
                {
                    thirdList.Add(secondList[j]);
                    j++;
                }
                while (i < firstList.Length)
                {
                    thirdList.Add(firstList[i])
                    i++
                }
                while (j <secondList.Length)
                {
                    thirdList.Add(secondList[j])
                    j++
                }
            }
            Console.WriteLine(thirdList);
        }
    }
}

