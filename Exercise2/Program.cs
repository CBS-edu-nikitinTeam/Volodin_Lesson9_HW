using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayHandler handler = new ArrayHandler();
            int[] array = handler.DefineArray();

            if (array != null)
            {
                handler.FillArray(ref array);
                handler.CheckArray(array);
            }
        }
    }
}