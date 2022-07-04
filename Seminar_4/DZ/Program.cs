/* 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

вариант 1:
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int Pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число "+ number + " в степени " + Pow + " = " + Math.Pow(number,Pow));*/

//вариант 2:
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());
int Pow (int number, int n)
{
	int result = number;
	for (int i = 1; i < n; i++)
	{
		result *= number;
	}
	return result;
}
Console.WriteLine("Число "+ number + " в степени " + n + " = " + Pow(number, n));

/* 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*int number = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
while (number != 0)
{
    Sum += number % 10;
    number = number/10; 
}
Console.WriteLine(Sum);*/

/* 29. Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

/*Console.WriteLine("Введите количество элементов: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(N);
Console.WriteLine($"[{String.Join("; ", array)}]");
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i<size; i++)
    {
        result[i] = new Random().Next(0,100);
    }
    return result;
}*/
