// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max) //строки m, столбцы n
{
    int[,] resultArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return resultArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = matrix[i, 0]; // макс. элемент
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, j])
                {
                    (matrix[i, k], matrix[i, j]) = (matrix[i, j], matrix[i, k]);
                }
            }
        }
    }
}
int[,] array = GetArray(rows, columns, 0, 10);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
SortArray(array);
Console.WriteLine("Сортировка по убыванию:");
PrintArray(array);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max) //строки m, столбцы n
{
    int[,] resultArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return resultArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(m, n, 0, 10);
Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine();

int row = 0;
int minSum = int.MaxValue;
for (int i = 0; i < m; i++)
{
    int rowsSum =0;
    for (int j = 0; j < n; j++)
    {
        rowsSum += array[i,j];
    }
    if (rowsSum < minSum)
    {
        minSum = rowsSum;
        row = i;
    }
}
Console.Write($"Строка c индексом {row} имеет минимальную сумму = {minSum}");
