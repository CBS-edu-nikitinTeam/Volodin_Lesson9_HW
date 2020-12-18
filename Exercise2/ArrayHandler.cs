using System;

namespace Exercise2
{
    public class ArrayHandler
    {
        /// <summary>
        /// Инициализация массива заданного пользователем размера
        /// </summary>
        /// <returns>Массив заданного размера</returns>
        public int[] DefineArray()
        {
            Console.WriteLine("Введите размер массива:");
            if (!int.TryParse(Console.ReadLine(), out int size))
            {
                Console.WriteLine("Введено некорректное число");
                return null;
            }

            if (size <= 0)
            {
                Console.WriteLine("Размер массива не должен быть меньше или равен нулю");
                return null;
            }

            return new int[size];
        }
        
        /// <summary>
        /// Заполнение массива случайными целыми числами
        /// </summary>
        /// <param name="array">Массив для заполнения</param>
        public void FillArray(ref int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
        }
        
        /// <summary>
        /// Проверка массива на наибольшее значение, наименьшее значение,
        /// общую сумму элементов, среднее арифметическое
        /// и вывести все нечетные числа.
        /// </summary>
        /// <param name="array">Массив для проверки</param>
        public void CheckArray(int[] array)
        {
            int max = array[0],
                min = array[0],
                sum = default,
                average = default;

            string oddNumbers = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] % 2 != 0)
                {
                    oddNumbers = (string.IsNullOrWhiteSpace(oddNumbers) == true)
                        ? $"{array[i]}"
                        : $"{oddNumbers}, {array[i]}";

                }
                
                sum += array[i];
            }

            average = sum / array.Length;

            Console.WriteLine($"Максимальное значение в массиве {max}");
            Console.WriteLine($"Минимально значение в массиве {min}");
            Console.WriteLine($"Сумма всех элементов в массиве {sum}");
            Console.WriteLine($"Среднее арифметическое {average}");

            if (!string.IsNullOrWhiteSpace(oddNumbers))
            {
                Console.Write($"Все нечетные числа в массиве: {oddNumbers}");
            }
        }
    }
}