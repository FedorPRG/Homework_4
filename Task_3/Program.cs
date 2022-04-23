void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[length - 1]}.");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
