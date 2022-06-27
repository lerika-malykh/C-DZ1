/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8*/
/*int number = new Random().Next(10,100);
Console.WriteLine($"Рандомное число {number}");
int digitOne = number/10;
int digitTwo = number % 10;
Console.WriteLine($"Первая цифра числа {digitOne}");
Console.WriteLine($"Вторая цифра числа {digitTwo}");
int max = Math.Max(digitOne,digitTwo);
Console.WriteLine($"Максимальное число из двух {max}");*/

/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/
/*int number = new Random().Next(100,1000);
Console.WriteLine(number);

int SearchNumber(int number) 
{
    int first = number / 100; // 456 -> 4
    int third = number % 10; // 456 -> 6
    return first * 10 + third;  // 4,6 -> 4*10 + 6 = 46
}

Console.WriteLine(SearchNumber(number));*/

/*int a = new Random().Next(10, 100);
int b = new Random().Next(10, 100);
Console.WriteLine(a);
Console.WriteLine(b);
int max = Math.Max(a,b);
int min = Math.Min(a,b);
int c = max % min;
if (c == 0)
    Console.WriteLine("число А кратно В");
    else 
    Console.WriteLine("остаток от деления "  +  c);*/

/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да*/
int number = Convert.ToInt32(Console.ReadLine());
bool paritycheck(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}
Console.WriteLine(paritycheck(number));
