// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;



Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
MinSum(array);
WriteLine();


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

static void MinSum(int[,] array)
        {
            int[] sum = new int[array.GetLength(0)];
            int str = 1;

            for (int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0;j < array.GetLength(1); j++)
                {
                    sum[i] += array[i,j];
                }
            }

            int min = sum[0];

            for (int i = 0; i < sum.Length - 1; i++)
            {
                if (min > sum[i + 1])
                {
                    min = sum[i + 1];
                    str = i + 2;
                }
            }

            WriteLine("Наименшая сумма элементов находится в " + str + " строке");
        }
