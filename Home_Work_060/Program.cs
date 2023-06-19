// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


using System;

    internal class Program
    {
        static void rndArr(int[,,] arr)
        {
            Random rnd = new Random();
            bool exist;
            int rndNew;
            for(int i = 0;  i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2);)
                    {
                        exist = false;
                        rndNew = rnd.Next(10,100);

                        for (int a = 0; a < arr.GetLength(0); a++)
                        {
                            for (int b = 0; b < arr.GetLength(1); b++)
                            {
                                for (int c = 0; c < arr.GetLength(2); c++)
                                {
                                    if (arr[a, b, c] == rndNew)
                                    {
                                        exist = true;
                                        break;
                                    }
                                    if (exist == true)
                                        break;
                                }
                                if (exist == true)
                                    break;
                            }
                            if (exist == true)
                                break;
                        }

                        if (!exist)
                        {
                            arr[i, j, k] = rndNew;
                            k++;
                        }
                    }
                }
            }
        }

        static void PrintArray(int[,,] arr)
        {
            for(int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    for(int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i,j,k]} ({i},{j},{k}) \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Размер трёхмерного массива будет [4,4,4] ");
                      

            int[,,] arr = new int[4,4,4];
            
            rndArr(arr);

            PrintArray(arr);

            Console.ReadLine();
        }
    }
