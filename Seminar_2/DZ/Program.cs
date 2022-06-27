// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int number = new Random().Next(100,1000);
Console.WriteLine(number);
int SearchNumber(int number) 
{
    int digit1 = number % 100; 
    int digit2 = digit1 / 10; 
    return digit2;  
}
Console.WriteLine("Вторая цифра нашего числа - "+ SearchNumber(number));*/

//2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    Console.WriteLine("Третья цифра нашего числа - " + number.ToString()[2]);
}
else
{
    Console.WriteLine("У данного числа нет 3-й цифры!");
}
*/

//3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//вариант 1.
/*Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber >= 1 && dayNumber <= 7)
{
    if (dayNumber >= 1 && dayNumber <=5)
    {
    Console.WriteLine("Будний день!");
    }
    else
    {
    Console.WriteLine("Выходной день!");;
    }
}
else
    {
    Console.WriteLine("Ошибка! Такого дня не существует!");;
    }
*/
//вариант 2.
Console.Write("Введите номер дня недели (от 1 до 7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());    
if (dayNumber >= 1 && dayNumber <=5)
    {
    Console.WriteLine("Будний день!");
    }
    else
    {
    Console.WriteLine("Выходной день!");;
    }
