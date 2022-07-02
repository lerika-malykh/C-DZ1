// Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());
if (X > 0 && Y > 0)
{
   Console.WriteLine("Четверть: 1");
}
if (X < 0 && Y > 0)
{
   Console.WriteLine("Четверть: 2");
}
if (X <0 && Y <0)
{
   Console.WriteLine("Четверть: 3");
}
if (X > 0 && Y < 0)
{
   Console.WriteLine("Четверть: 4");
}
*/
/*Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*/
/*int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter == 1)
{
    Console.Write("X > 0; Y > 0");
}
if (quarter == 2)
{
    Console.Write("X < 0; Y > 0");
}
if (quarter == 3)
{
    Console.Write("X < 0; Y < 0");
}
if (quarter == 4)
{
    Console.Write("X > 0; Y < 0");
}
*/

/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/
/*int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());
double distance = 0;
distance = Math.Round(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)));
Console.Write("Расстояние между точками = " + distance);*/

/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i ++)
{
    Console.Write(i * i + " ");
}


