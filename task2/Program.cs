// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] PrintArray(int num)
{
    {
        int[] array = new int[num];
        for (int i = 0; i < num; i++)
        {
            array[i] = new Random().Next(-100, 100);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        return array;
    }
}

void oddnums(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) count++;
    }

    Console.WriteLine($"В массиве {count} чётных чисел.");
}

Console.WriteLine("Введите размерность массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = PrintArray(length);
Console.WriteLine();
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {oddnums}.");
