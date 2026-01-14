using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TargetSemOtimizacao();
        }

        static void TargetSemOtimizacao()
        {
            int[] array = { 2, 5, 7, 15 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] + array[j] == 12)
                    {
                        Console.WriteLine($"Índices: {i}, {j}");
                        return;
                    }
                }
               
            }
        }
        static int[] TargetOtimizado(int[]nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complemento = target - nums[i];

                if (map.ContainsKey(complemento))
                {
                    return new int[] { map[complemento], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }

            return new int[0];
        }
    }
}
