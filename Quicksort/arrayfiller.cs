public static class ArrayCreation
{
    public static int[] CreateArray(this int size, int min = 1, int max = 10)
    {
        int[] collection = new int [size];
        for (int i = 0; i < size; i++)
        {
            collection[i] = Random.Shared.Next(min, max);
        }
        return collection;
    } 
    public static void Show(this int[] collection)
    {
        Console.WriteLine($"[{string.Join(",", collection)}]");
    }
    
}