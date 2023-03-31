public static class Sorting
{
    public static int[] QuickSort(this int[] collection, int left, int right)
    {
        int pivot = collection[Random.Shared.Next(left, right)];
        int i = left;
        int j = right;
        while (i <= j)
        {
            while (collection[i] < pivot) i++;
            while (collection[j] > pivot) j--;
            if (i <= j)
            {
                int t = collection[i];
                collection[i] = collection[j];
                collection[j] = t;
                i++;
                j--;
            }
        }
        if(i < right) QuickSort(collection, i, right);
        if(j > left) QuickSort(collection, left, j);
        return collection;
    }
    public static int[] MyQuickSort(this int[] collection, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = collection[Random.Shared.Next(left, right)];
        while (i <= j)
        {
            while (collection[i] < pivot) i++;
            while (collection[j] > pivot) j--;
            if (i <= j)
            {
                int t = collection[i];
                collection[i] = collection[j];
                collection[j] = t;
                i++;
                j--;
            }

        }
        if (i < right) MyQuickSort(collection, i, right);
        if (j > left) MyQuickSort(collection, left, j);
        return collection;
    }
}

// 8 7 6 4  9 7  4 6  4 3 3 1 2 2  2 2 2 