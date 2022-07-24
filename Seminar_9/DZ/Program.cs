/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

/*Console.WriteLine("Введите число M:");
int M =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N =Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return(start + ", " + PrintNumbers(start +1,end));
}
Console.WriteLine(PrintNumbers(M, N));
*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int PrintNumbers(int start, int end)
{
    int sum = 0;
    if (start == end) return end;
    else
    {
        sum += start;
        return (sum + PrintNumbers(start + 1, end));
    }
}
Console.WriteLine("Сумма элементов от " + M + " до " + N + " = " + PrintNumbers(M, N));
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int Akkerman(int x, int y)
{
    if (x == 0) return y + 1;
    else
    {
        if ((x > 0) && (y == 0))
            return Akkerman(x - 1, 1);
        else return Akkerman(x - 1, Akkerman(x, y - 1));
    }
}
Console.WriteLine("Функция Аккермена = " + Akkerman(M, N));