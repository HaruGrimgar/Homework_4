/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
+ введите кол. элементов/ минимальный порог случ, максимальный порог случ */

int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayFiller(int size, int smallest, int largest)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(smallest, largest + 1);
    }
    return array;
}

void OutputMassive(int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int size = InputInt("Введите размер массива");
int smallest = InputInt("Введите минимально возможное значение числа в массиве");
int largest = InputInt("Введите максимальнл возможное значение числа в массиве");

OutputMassive(ArrayFiller(size, smallest, largest), size);