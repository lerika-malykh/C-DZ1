// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/* m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

/*int rows = int.Parse(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(11);
        // [0;11) -> [0;10]
        Console.Write(matrix[i,j] + "\t"); // Литералы
    }
    Console.WriteLine();
}
*/

/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

/*int m = Int32.Parse(Console.ReadLine());
int n = Int32.Parse(Console.ReadLine());
int [,] matrix = new int [m,n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int Amn = i + j;
        Console.Write(Amn + "\t");
    }
    Console.WriteLine();
}
*/

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/*Console.WriteLine("задайте массив");
int m = Int32.Parse(Console.ReadLine());
int n = Int32.Parse(Console.ReadLine());
int [,] matrix = { { 2 , 3 , 5 , 5 },
                    { 3 , 4,  6 , 7 },
                    { 4 , 3 , 5 , 6 } };


for (int i = 0; i < matrix.GetLength(0); i+=2)
{
    for (int j = 0; j < matrix.GetLength(1); j+=2)
    {
        matrix [i,j] = Convert.ToInt32(Math.Pow(matrix [i,j] , 2));
        Console.Write( $ "Ответ: " + {matrix [i,j]} + "\t");
    }
    Console.WriteLine();
}*/

/*Задача 51: Найти сумму элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

/*Console.WriteLine("Задайте массив:");
int m = Int32.Parse(Console.ReadLine());
int n = Int32.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
int result = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(15);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int k = 0; k < matrix.GetLength(0); k++)
{
    for (int l = 0; l < matrix.GetLength(1); l++)
    {
        if (k == l)
        {
            result += matrix[k, l];
        }
    }
}
Console.WriteLine($"Сумма элеметнов главной диагонали : {result}");*/


