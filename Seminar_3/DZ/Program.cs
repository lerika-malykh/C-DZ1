/*19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*Console.WriteLine("Введите 5ти-значное число: ");
string number = Console.ReadLine();
bool palindrom(string number)
{
    return number[0]==number[4] && number[1]==number[3];
}
Console.WriteLine(palindrom(number));*/
//Вариант решения 2
Console.WriteLine("Введите 5ти-значное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
bool palindrom(int num)
{
    return ((num%10 == num%10000) && ((num/1000)%10 == (num/100)%10));
}
Console.WriteLine(palindrom(number));


/* 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введиты координаты 1-й точки: ");
int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиты координаты 2-й точки: ");
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());
int Z2 = Convert.ToInt32(Console.ReadLine());
double distance = 0;
distance = Math.Round(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2)), 2);
Console.Write("Расстояние между точками = " + distance);*/

/*23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i ++)
{
    Console.WriteLine("Куб числа " + i + " = " + Math.Pow(i, 3));
}*/