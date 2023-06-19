// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


using System;


namespace DZ
{
    internal class Program
    {       

        static void showArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void fillArr(int[,] arr, int side, int value)
        {
            for (int i = 0, a = 0; a < arr.GetLength(0) * arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(0) - i; j++, value++, a++)
                {
                    arr[i, j] = value;
                }
                for (int k = i + 1; k < arr.GetLength(0) - i; k++, value++, a++)
                {
                    arr[k, (arr.GetLength(0) - i) - 1] = value;
                }
                for (int k = (arr.GetLength(0) - i) - 2; k > i; k--, value++, a++)
                {
                    arr[(arr.GetLength(0) - i) - 1, k] = value;
                }
                for (int k = (arr.GetLength(0) - i) - 1; k > i; k--, value++, a++)
                {
                    arr[k, i] = value;
                }
                
            }
        }



        static void Main(string[] args)
        {
            Console.Write("Введите размер двумерного массива: ");
            int side = int.Parse(Console.ReadLine());

            Console.Write("Введите число от которого начинаем отсчёт: ");
            int value = int.Parse(Console.ReadLine());

            int[,] arr = new int[side, side];

            fillArr(arr, side, value);
            
            showArr(arr);                                   

            

            Console.ReadLine();
        }
    }
}