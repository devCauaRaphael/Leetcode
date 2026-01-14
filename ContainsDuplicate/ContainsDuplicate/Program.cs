using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContainsDuplicate();
        }

        static bool ContainsDuplicate()
        {
            int[] array = { 7, 9, 8, 10, 11, 7, 10 };
         

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j]) return true;
                }
            }
            return false;
        }

        static bool ContainsDuplicateOtimizado()
        {
            int[] array = { 7, 9, 8, 10, 11, 7, 10 };

            HashSet<int> vistos = new HashSet<int>();

            foreach (int num in array)
            {
                if (vistos.Contains(num))
                    return true;

                vistos.Add(num);
            }

            return false;
        }

    }
}
