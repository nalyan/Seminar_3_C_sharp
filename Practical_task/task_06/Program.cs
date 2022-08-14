// 6. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();


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

void FillFind(int[] array, int min)
{
    for(int i=0; i<array.Length; i++) array[i] = min++;
}

int[] array = new int[123];
int[] findArray = new int[90];
FillArray(array, 0, 1000);
FillFind(findArray, 10);
PrintArray(array);
PrintArray(findArray);
