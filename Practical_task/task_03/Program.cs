// 3. Написать программу замену элементов массива на противоположные
Console.Clear();

void FillArray (int[] array, int min, int max)
{
    var random = new Random();
    for(int i=0; i<array.Length; i++) array[i] = random.Next(min, max+1);
}

void PrintArray (int[] array)
{
    for(int i=0; i<array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void ReplaceArray (int[] array)
{
    int[] arrayNew = new int[array.Length];
    for(int i=0; i<array.Length; i++)
    {
        arrayNew[i] = -array[i];
    }
}

int[] array = new int[10];

FillArray(array, -100, 100);
PrintArray(array);

PrintArray(ReplaceArray(array));
//ReplaceArray(array);