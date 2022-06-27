//Console.Write("Введите число:");
//int value = Convert.ToInt32(Console.ReadLine());
//int result = value*value;
//Console.Write("Квадрат данного числа = ");
//Console.WriteLine(result);

//Console.Write("Введите 1-е целое число:");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 2-е целое число:");
//int squarenumber = Convert.ToInt32(Console.ReadLine());
//if (squarenumber == number*number)
//{
//    Console.WriteLine("1-ое число является квадратом 2-го!");
//}
//else
//{
//   Console.WriteLine("1-ое число не является квадратом 2-го!");
//}

//Console.Write("Введите день недели ");
//int dayNumber = Convert.ToInt32(Console.ReadLine());

//if (dayNumber >= 1 && dayNumber <= 7)
//{
/* if (dayNumber == 1)
{
 Console.WriteLine("Понедельник");
}
if (dayNumber == 2)
{
 Console.WriteLine("Вторник");
}
if (dayNumber == 3)
{
 Console.WriteLine("Среда");
}
if (dayNumber == 4)
{
 Console.WriteLine("Четверг");
}
if (dayNumber == 5)
{
 Console.WriteLine("Пятница");
}
else
{
 Console.WriteLine("Error 404, day not found");
}
}*/

// Напишите программу, которая на вход принимает 
//одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativN = N * (-1);
while (negativN <= N)
{
    Console.WriteLine(negativN);
    negativN ++;
}