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

int[] array = new int [new Random().Next(1, 11)];
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
Console.WriteLine($"Сумма элементов на нечетных местах: {sum}");