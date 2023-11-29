using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortConsola
{
    internal class Program
    {
        // Bubble Sort = compara un par de elementos adyacentes, los cuales se intercambian de posicion si no están en órden.
        // Complejidad de Tiempo = O(n^2)
        // Esta bien para programas con pocos datos por ordenar
        // Por favor no lo usen para ordenar muchos datos!! Será muy ineficiente.
        static void Main(string[] args)
        {
            int[] array = { 9, 1, 8, 2, 7 };
            
            BubbleSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j] < array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }
    }

    
}

