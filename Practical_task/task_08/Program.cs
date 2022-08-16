// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void FillArray (int[] array, int min, int max)
{ 
var random = new Random();
for(int i=0; i<array.Length; i++) array[i] = random.Next(min, max+1);
}
void PrintArray(int[] array)
{
    foreach(var i in array) Console.Write($"{i} ");
    Console.WriteLine();
}

Console.Clear();
int[] array = new int[11];
FillArray(array,-10,10);
PrintArray(array);

for(int i=0; i<(array.Length/2); i++)
{
    int j = array.Length - 1 - i;
    Console.WriteLine($"Произведение {i+1} пары чисел в массиве = {array[i]*(array[j])}");
}