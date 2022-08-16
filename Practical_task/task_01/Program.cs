// 1. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray (int[] array, int min, int max)
{
    for(int index = 0; index<array.Length; index++)
    {
        array[index] = new Random().Next(min, max+1);
    }
}
void PrintArray (int[] array)
{
    for(int index = 0; index<array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
}

Console.Clear();
int[] array = new int[8];
FillArray(array, 0, 1);
PrintArray(array);