using System;

namespace Aero.Sort;

public static partial class Sort
{
    public static void Insertion<T>(this T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length <= 1)
        {
            return;
        }
        for (int i = 1; i < array.Length; i++)
        {
            T key = array[i];            
            int j = i - 1;

            while (j >= 0 && array[j].CompareTo(key) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }
}