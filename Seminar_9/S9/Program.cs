// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число N:");
int N =Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return(start + ", " + PrintNumbers(start +1,end));
}
Console.WriteLine(PrintNumbers(1, N));*/

// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
/*Console.WriteLine("Введите число N:");
int M =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N =Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return(start + ", " + PrintNumbers(start +1,end));
}
Console.WriteLine(PrintNumbers(M, N));*/

/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

/*Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int SummDigit(int numberSumm)
{
    //if(numberSumm / 10 == 0) return numberSumm % 10;
    if (number == 0) return 0;
    return numberSumm % 10 + SummDigit(numberSumm/10);
}

Console.WriteLine(SummDigit(number));*/

/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.WriteLine("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Power(int number, int digre)
{
    if(digre == 0) return 1;
    //if(digre == 1) return number;
    return number * Power(number, digre - 1);
}

Console.WriteLine(Power(numberA, numberB));
