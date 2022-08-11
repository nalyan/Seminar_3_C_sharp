// Задать массив из 8 элементов и вывести их на экран
Console.Clear();

int[] array = {1,9,8,4,6,10,68,48};
int length = array.Length;
int index = 0;

while (index < length)
{
    Console.Write($"{array[index]}, ");
    index++;
}
