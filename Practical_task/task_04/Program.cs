// 4. Определить, присутствует ли в заданном массиве, некоторое число

void FillArray(int[] array, int min, int max)
{
    var random = new Random();
    for(int i=0; i<array.Length; i++) array[i] = random.Next(min, max+1);
}
void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}
int InputNumber ()
{
    Console.Write("Введите искомое число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}
bool FindArray(int[] array, int number)
{
    bool result = false;
    for(int i=0; i<array.Length; i++) if(array[i] == number) result = true;
    return result;
}

Console.Clear();
int[] array = new int[10];
FillArray(array, -100, 100);
PrintArray(array);
int number = InputNumber();
bool result = FindArray(array, number);
if(result==true) Console.WriteLine($"Число {number} присутствует в данном массиве");
else Console.WriteLine($"Число {number} отсутствует в данном массиве");
