using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparandoLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComparandoAsLetras();
        }
       static void ComparandoAsLetras()
        {
            string x = "usuario";
            string y = "topo";

            for (int i = 0; i <= x.Length; i++)
            {
                if (x[i] != y[i]) Console.WriteLine(x[i]); Console.WriteLine(y[i]);
            }
            Console.ReadKey();
        }
    }
}
