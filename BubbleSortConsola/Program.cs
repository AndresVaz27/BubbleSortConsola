using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            
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

