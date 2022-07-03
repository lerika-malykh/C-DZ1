/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i<=number; i++)
{
    sum += i;
}
Console.WriteLine($"Cумма чисел: {sum}");*/

/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (number/10 != 0)
{
    number /= 10; 
    i ++;
}
Console.WriteLine(i);*/

/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
int number = Convert.ToInt32(Console.ReadLine());
int Fact = 1;
for (int i = 1; i<=number; i++)
{
    Fact *= i;
}
Console.WriteLine($"Факториал: {Fact}");*/

/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join("; ", array)}]");
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i<size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}





