﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Введите количество строк массива:");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Int32.Parse(Console.ReadLine());
double[,] matrix = new double[m, n];
void GetArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble()*10,2);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t"); 
        }
    Console.WriteLine();
    }
}
Console.WriteLine("Массив вещественных чисел готов:");
GetArray(matrix);
Console.WriteLine();
PrintArray(matrix);