// 6. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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

Console.Clear();

int[] array = new int[123];
FillArray(array, 0, 1000);
PrintArray(array);
int min = 10;
int max = 99;
int count = 0;
for (int i=0; i<array.Length; i++)
{
    for (int j = min; j<max+1; j++)
    {
        if (j == array[i]) count++;
    }    
}
Console.WriteLine($"В данном массиве {count} элементов из отрезка [{min},{max}]");
