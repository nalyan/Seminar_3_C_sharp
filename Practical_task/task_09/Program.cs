// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray (double[] array, double min, double max)
{ 
var random = new Random();
for(int i=0; i<array.Length; i++) array[i] = random.NextDouble() * ((max - min) + min);
}
void PrintArray (double[] array)
{
    foreach(var i in array) Console.Write($"{i} ");
    Console.WriteLine();
}
double MaxArray (double[] array)
{
    double max = array[0];
    for(int i=1; i<array.Length; i++) if(array[i]>max) max = array[i];
    return max;
}
double MinArray (double[] array)
{
    double min = array[0];
    for(int i=1; i<array.Length; i++) if(array[i]<min) min = array[i];
    return min;
}

Console.Clear();
double[] array = new double[10];
FillArray(array,-20,20);
PrintArray(array);
double max = MaxArray(array);
double min = MinArray(array);
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");
Console.WriteLine($"Max - Min = {max-min}");
