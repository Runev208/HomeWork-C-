﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7, 8 -7, 1 9

/*
int lenghtArray = 3;
int highthArray = 4;

double[,] array = new double[highthArray,lenghtArray]; 
FillArrayRandomDouble();
ShowArray();

void FillArrayRandomDouble(int min = -10, int max = 10)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min,max) + random.NextDouble();
        }
    }
}

void ShowArray()
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write ($"{array[i, j] : 0.0}\t");
        }

        Console.WriteLine();
    }
}
*/

