// 2. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.Clear();

void FillArray(int[] array, int min, int max)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumPositive (int[] array)
{
    int resultPositive = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]>0) resultPositive = resultPositive + array[i];
    }
    return resultPositive; 
}
int SumNegative (int[] array)
{
    int resultNegative = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]<0) resultNegative = (resultNegative + array[i]);
    }
    return resultNegative; 
}
int[] array = new int[12];
FillArray(array, -9, 9); // изменил диапазон для того, чтобы считать отрицательные
PrintArray(array);
int resultPositive = SumPositive(array);
int resultNegative = SumNegative(array);

Console.WriteLine($"Сумма положительных элементов массива = {resultPositive}");
Console.WriteLine($"Сумма отрицательных элементов массива = {resultNegative}");
