// Определить, присутствует ли в заданном массиве, некоторое число
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[10];


int index = 0;
int l = array.Length;
int k = 0;

while(index<l)
{
    array [index] = new Random().Next(0,10);
    Console.WriteLine($"{array[index]} ");
    if (array[index]==number) 
    {
        Console.WriteLine($"Число {number} присутствует в массиве под индексом {index}");
        k = 1;
    }
    index++;
}
if (k != 1) Console.WriteLine("Нет такого числа в массиве");