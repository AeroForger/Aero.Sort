using System;

namespace Aero.Sort;

public static partial class Sort
{
    public static void Bogo<T>(this T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length <= 1) return;

        var random = Random.Shared;
        int attempts = 0;
        
        int maxAttempts = 1_000_000; 

        while (!IsSorted(array))
        {
            Shuffle(array, random);
            attempts++;

            if (attempts >= maxAttempts)
            {
                throw new TimeoutException($"Bogo sort gave up after {maxAttempts} attempts. The universe is against you.");
            }
        }
    }

    private static bool IsSorted<T>(T[] array) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i].CompareTo(array[i + 1]) > 0)
            {
                return false;
            }
        }
        return true;
    }

    private static void Shuffle<T>(T[] array, Random random)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int j = random.Next(i, n);
            
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}