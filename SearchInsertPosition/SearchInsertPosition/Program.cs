using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SearchInsertPosition();
            SearchInsertPositionWithFor();
        }

        static void SearchInsertPosition()
        {
            int[] array = { 2, 4, 12, 17, 22, 35 };
            int target = 8;

            // Ponteiro da esquerda:
            // representa o INÍCIO do intervalo de busca
            int left = 0;

            // Ponteiro da direita:
            // representa o FIM do intervalo de busca
            int right = array.Length - 1;

            // Enquanto existir um intervalo válido de busca
            // Se left ultrapassar right, significa que o target NÃO existe no array
            while (left <= right)
            {
                // Calcula o índice do meio do intervalo atual
                // É nesse ponto que "cortamos" o array em duas partes
                int mid = (left + right) / 2;

                // Caso 1:
                // Se o valor do meio for exatamente igual ao target,
                // encontramos o número e podemos encerrar o algoritmo
                if (array[mid] == target)
                {
                    // Imprime a posição onde o target foi encontrado
                    Console.WriteLine(mid);
                    return;
                }
                // Caso 2:
                // Se o valor do meio for MENOR que o target,
                // então o target só pode estar na metade DIREITA do array
                else if (array[mid] < target)
                {
                    // Descartamos toda a metade esquerda,
                    // movendo o ponteiro left para depois do meio
                    left = mid + 1;
                }
                // Caso 3:
                // Se o valor do meio for MAIOR que o target,
                // então o target só pode estar na metade ESQUERDA do array
                else
                {
                    // Descartamos toda a metade direita,
                    // movendo o ponteiro right para antes do meio
                    right = mid - 1;
                }
            }
            // Se o while terminar, significa que o target NÃO foi encontrado
            // Nesse problema (Search Insert Position),
            // o valor de 'left' indica exatamente a posição
            // onde o target deveria ser inserido para manter o array ordenado
            Console.WriteLine(left);
        }

        static void SearchInsertPositionWithFor()
        {
            int[] array = { 2, 4, 12, 17, 22, 35 };
            int target = 8;
            int right = array.Length - 1;
            int i = 0;

            for (i = 0; i <= right;)
            {
                int mid = (i + right) / 2;
                if (array[mid] == target)
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if (array[mid] < target)
                {
                    i = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine(i);
        }
    }
}
