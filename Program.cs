// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив или массив 4х7:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[4, 7];

Console.WriteLine("Введите элементы массива:");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("Элемент [{0}, {1}]: ", i, j);
        array[i, j] = int.Parse(Console.ReadLine());
    }
}

int minSum = int.MaxValue;
int minIndex = -1;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        minIndex = i;
    }
}

Console.WriteLine("Номер строки с наименьшей суммой элементов: {0}", minIndex + 1);

