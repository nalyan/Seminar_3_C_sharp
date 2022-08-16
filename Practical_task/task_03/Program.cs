// 3. Написать программу замены элементов массива на противоположные

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

Console.Clear();

int[] array = new int[10];
FillArray(array, -100, 100);
PrintArray(array);

int[] arrayNew = new int[array.Length];
for(int i=0; i<array.Length; i++)
  {
    arrayNew[i] = -array[i];
  }
PrintArray(arrayNew);
