using static ArrayCreation;
using static Sorting;

int size = 20;
int[] arr = size.CreateArray();
                    arr.Show();
// arr.QuickSort(0, size - 1)
//                     .Show();
arr.MyQuickSort(0, size-1)
    .Show();