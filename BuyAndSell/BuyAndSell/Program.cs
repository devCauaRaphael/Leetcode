using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuyAndSell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuyAndSell();
        }

        static void BuyAndSell()
        {
            int[] array = { 8, 40, 22, 54, 1, 35};
            int compra = array[0];
            int venda = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < compra) compra = array[i];
                else
                {
                    int lucroAtual = array[i] - compra;

                    if (lucroAtual > venda)
                        venda = lucroAtual;
                }
                
            }   
            if (lucro == 0) Console.WriteLine(0);
            else Console.WriteLine(lucro);
           
        }
    }
}
