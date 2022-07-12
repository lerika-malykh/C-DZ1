// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*int[] array = new int[new Random().Next(1, 11)];
int size = array.Length;
int eventNumber = 0;
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);

    if (array[i] % 2 == 0)
    {
        eventNumber = array[i];
        sum += 1;
    }
}
Console.WriteLine($"Исходный массив: [{String.Join(",", array)}]");
Console.WriteLine($"количество четных элементов: {sum}");*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

/*int[] array = new int [new Random().Next(1, 11)];
int size = array.Length;
int oddIndex = 0;
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-10, 100);

    if (i % 2 != 0)
    {
        oddIndex = i;
        sum += array[oddIndex];
    }
}
Console.WriteLine($"Исходный массив: [{String.Join(",", array)}]");
Console.WriteLine($"Сумма элементов на нечетных местах: {sum}");*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] array = new double[10];
int size = array.Length;
double result = 0;
double max = double.MinValue;
double min = double.MaxValue;
for (int i = 0; i < size; i++)
{
    array[i] = Math.Round((new Random().Next(1, 100) * 0.01), 3); //array[i] = new Random().NextDouble() * 100;
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {Math.Round(min,3)}");
result = Math.Round(Math.Abs(max - min), 3);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result}");