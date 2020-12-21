using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayHandler handler = new ArrayHandler();
            // handler - не лучшее имя. Мы когда будем проходить события, увидешь что обработчик у собития есть,
            // поэтому и принято классы, которые отвечают за событийную модель так именновать.
            int[] array = handler.DefineArray();

            if (array != null)
            {
                handler.FillArray(ref array);
                handler.CheckArray(array);
            }
        }
    }
}