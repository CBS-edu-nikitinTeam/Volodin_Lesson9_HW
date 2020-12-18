using System;
using System.Diagnostics.PerformanceData;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arraySize = 10;
            int[] array = new int[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            int[] reversedArray = MyReverse(array);
            int[] subArray = SubArray(array, arraySize / 2, arraySize);

            Console.WriteLine("Исходный массив:");
            DisplayArray(array);
            Console.WriteLine("Обратный массив:");
            DisplayArray(reversedArray);
            Console.WriteLine("Массив после обработки методом SubArray:");
            DisplayArray(subArray);
        }

        static int[] MyReverse(int[] array)
        {
            int [] resultArray = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                resultArray[array.Length - 1 - i] = array[i];
            }

            return resultArray;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] resultArray = new int[count];

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (index + i > array.Length - 1)
                {
                    resultArray[i] = 1;
                }
                else
                {
                    resultArray[i] = array[index + i];
                }
            }

            return resultArray;
        }

        public static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write((array.Length - 1 == i) ? $"{array[i]}" : $"{array[i]}, ");
            }
            Console.Write(Environment.NewLine);
        }
    }
}