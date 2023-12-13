int[] array = { 1, 2, 3, 4, 5 };
void PrintArrayNambers(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayNambers(array, index - 1);
        }
    }
Console.Clear();
PrintArrayNambers(array, array.Length - 1);


