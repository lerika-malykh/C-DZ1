// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
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

void ChandesRows(int[,] matrix)
{
    int rowCount = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[rowCount, i];
        matrix[rowCount, i] = temp;
    }
}
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
ChandesRows(array);
PrintArray(array);
*/

//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) // Строчки
    {
        for (int j = 0; j < n; j++) // Столбцы
        {
            result[i, j] = new Random().Next(min, max + 1); // [min,max]
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t"); // tab - "\t"
        }
        Console.WriteLine();
    }
}
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("Результат:");
if (rows != columns)
{
    System.Console.WriteLine("Замена строк со столбцами  невозможна!!!");
}
else
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[j ,i] + "\t");
        }
        System.Console.WriteLine();
    }
}
*/

/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1*/

/*Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) // Строчки
    {
        for (int j = 0; j < n; j++) // Столбцы
        {
            result[i, j] = new Random().Next(min, max + 1); // [min,max]
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t"); // tab - "\t"
        }
        Console.WriteLine();
    }
}
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int minNumber = int.MaxValue;
int indexRows = 0;
int indexColumns = 0;

for (int k = 0; k < array.GetLength(0); k++)
{
    for (int m = 0; m < array.GetLength(1); m++)
    {
        if (array[k,m] < minNumber)
        {
            minNumber = array[k,m];
            indexRows = k;
            indexColumns = m;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"Минимальный элемент находится в строке :{indexRows}, в столбце: {indexColumns}");
Console.WriteLine();
Console.WriteLine("Результат:");
for (int r = 0; r < array.GetLength(0); r++)
{
    if (r == indexRows) continue;
    for (int t = 0; t < array.GetLength(1); t++)
    {
        if (t == indexColumns) continue;
        Console.Write(array[r,t] + "\t");
    }
    Console.WriteLine();
}*/

int rows = 3;
int columns = 3;
 
int[,] matrix = new int[rows, columns];
 
int minValue = int.MaxValue; //Значение минимального элемента
int minIndexRows = 0;        //Задание индекса минимального элемента (строчка)
int minIndexColumns = 0;     //Задание индекса минимального элемента (столбец)
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // [0,10]
        Console.Write(matrix[i, j] + "\t");
        if (minValue > matrix[i, j])
        // minValue = 5(пусть)
        // 5>0, то минимум уже не 5, minValue = 0
        {
            minValue = matrix[i, j];
            minIndexRows = i;
            minIndexColumns = j;
        }
 
    }
    Console.WriteLine();
}
Console.WriteLine("Минимум:" + minValue);
Console.WriteLine("Результат:");
for (int i = 0; i < rows; i++) // rows = GetLength(0)
{
    if (i != minIndexRows)
    {
        for (int j = 0; j < columns; j++) //columns - GetLength(1)
        {
            if (j != minIndexColumns)
            {
                Console.Write(matrix[i,j] + "\t");
 
            }
        }
        Console.WriteLine();
    }
}




