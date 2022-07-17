// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*Console.WriteLine("Введите количество строк массива:");
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
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

/*Console.WriteLine("Введите количество строк массива:");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Int32.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11);
        }
    }
}

void PrintArray(int[,] array)
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
Console.WriteLine("Массив:");
GetArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine("Введите индексы элемента массива:");
int indexRows = Int32.Parse(Console.ReadLine());
int indexColumns = Int32.Parse(Console.ReadLine());
if(indexRows > m || indexColumns > n)
{
    Console.WriteLine("Такого элемента в массиве нет");
    return;
}
Console.WriteLine($"Искомый элемент {matrix[indexRows, indexColumns]}");
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [rows,columns];
Console.WriteLine("Массив:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(11);
        Console.Write(matrix[i,j] + "\t");        
    }
    Console.WriteLine();
}
double sum = 0; //сумм элементов
for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i,j];
    }
    Console.WriteLine($"Среднее арифметическое элементов {j}-го столбца =  {sum/columns}"); 
}
