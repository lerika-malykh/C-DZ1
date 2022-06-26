// Задача 2. Макс и мин число.
/*Console.WriteLine("Введите 1-е число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("max = " + number1);
}
else
{
    Console.WriteLine("max = " + number2);
}
*/

//Задача 4. Макс из 3-х чисел.
/*Console.WriteLine("Введите 1-е число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine("max = " + max);
*/

//Задача 6. Четность числа.
/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine(number +" является ЧЕТНЫМ числом!");
}
else
{
    Console.WriteLine(number +" является НЕЧЕТНЫМ числом!");
}
*/

//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        Console.Write("Введите число от 1 до N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i <= N)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                i++;
            }
            else
            {
                i++;
            }       
        }
    
