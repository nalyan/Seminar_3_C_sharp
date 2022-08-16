// 7. Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray (int[] array, int min, int max)
{ 
var random = new Random();
for(int i=0; i<array.Length; i++) array[i] = random.Next(min, max+1);
}
void PrintArray(int[] array)
{
for(int i=0; i<array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine();
}
int SumOdd (int[] array)
{
int sumOdd = 0;
for(int i=0; i<array.Length; i=i+2) sumOdd=sumOdd+array[i]; //для позиции с нечетным индекса i=1
return sumOdd;
}

Console.Clear();
int[] array = new int[10];
FillArray(array, -10, 10);
PrintArray(array);
int result = SumOdd(array);
Console.WriteLine($"Сумма элементов в массиве на нечетных позициях = {result}");
