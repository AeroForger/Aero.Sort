using System;

namespace Aero.Sort;

public static partial class Sort
{
    public static void Quick<T>(this T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length <= 1)
        {
            return;
        }

        QuickSortRecursive(array, 0, array.Length - 1);
    }

    private static void QuickSortRecursive<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            QuickSortRecursive(array, low, pivotIndex - 1);
            QuickSortRecursive(array, pivotIndex + 1, high);
        }
    }

    private static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        int mid = low + (high - low) / 2;
        Swap(array, mid, high);
        
        T pivot = array[high];
        
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        
        return i + 1;
    }
    private static void Swap<T>(T[] array, int indexA, int indexB)
    {
        if (indexA == indexB) return;        
        (array[indexA], array[indexB]) = (array[indexB], array[indexA]);
    }
}