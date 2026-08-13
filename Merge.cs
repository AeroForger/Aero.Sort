using System;

namespace Aero.Sort;

public static partial class Sort
{
    public static void MergeSort<T>(this T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length <= 1)
        {
            return;
        }
        T[] tempArray = new T[array.Length];
        MergeSortRecursive(array, 0, array.Length - 1, tempArray);
    }

    private static void MergeSortRecursive<T>(T[] array, int left, int right, T[] tempArray) where T : IComparable<T>
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSortRecursive(array, left, mid, tempArray);
            MergeSortRecursive(array, mid + 1, right, tempArray);
            Merge(array, left, mid, right, tempArray);
        }
    }

    private static void Merge<T>(T[] array, int left, int mid, int right, T[] tempArray) where T : IComparable<T>
    {
        for (int i = left; i <= right; i++)
        {
            tempArray[i] = array[i];
        }
        int leftPointer = left;
        int rightPointer = mid + 1;
        int current = left;
        while (leftPointer <= mid && rightPointer <= right)
        {
            if (tempArray[leftPointer].CompareTo(tempArray[rightPointer]) <= 0)
            {
                array[current] = tempArray[leftPointer];
                leftPointer++;
            }
            else
            {
                array[current] = tempArray[rightPointer];
                rightPointer++;
            }
            current++;
        }

        while (leftPointer <= mid)
        {
            array[current] = tempArray[leftPointer];
            leftPointer++;
            current++;
        }
    }
}