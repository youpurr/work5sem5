// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] PrintArray(int num)
{
    double[] array = new double[num];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100) + new Random().NextDouble();
        Console.Write(Math.Round(array[i], 2) + " ");
    }
    return array;
}

double realnum(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach (double el in array)
    {
        if (el > max) max = el;
        if (el < min) min = el;
    }
    double diff = max - min;
    return Math.Round(diff, 2);
}


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = PrintArray(size);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {realnum(array)}.");