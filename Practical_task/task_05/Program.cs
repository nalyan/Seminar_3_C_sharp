// 5. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillArray(int[] array, int min, int max)
{
    var random = new Random();
    for(int i = 0; i<array.Length; i++) array[i] = random.Next(min, max+1);
}
void PrintArray (int[] array)
{
    for(int i=0; i<array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int CountEven(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++) if(array[i]%2==0) count++;
    return count;
}

Console.Clear();
int size = 10;
int[] array = new int[10];
FillArray(array, 100, 999); 
PrintArray(array);
int countEven = CountEven(array);
Console.WriteLine($"В данном массиве {countEven} четных чисел и {size - countEven} - нечетных");
