using System;

namespace Exercise4
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

            int[] arrayWithInsertedValue = InsertInArray(array, 0);

            Console.WriteLine("Исходный массив:");
            DisplayArray(array);
            Console.WriteLine("Массив с добавленным значением");
            DisplayArray(arrayWithInsertedValue);
        }

        static int[] InsertInArray(int[] array, int value)
        {
            int[] resultArray = new int[array.Length + 1];
            resultArray[0] = value;
            for (int i = 0; i < array.Length; i++)
            {
                resultArray[i + 1] = array[i];
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