using System;

namespace Aero.Sort;

public static partial class Sort
{
    public static void Bubble<T>(this T[] array) where T: IComparable<T>
    {
        if (array == null || array.Length <= 1)
        {
            return;
        }

        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
                    swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }

    }
}
