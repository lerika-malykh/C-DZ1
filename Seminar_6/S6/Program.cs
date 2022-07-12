/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/
/*int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray=PrintReversItem(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray(array);
Console.WriteLine(String.Join(" ", array));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray(int[] inArray)  //1-й способ
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = temp;
    }
}

int[] PrintReversItem(int[] inArray)  //2-й способ
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }

    return result;
}
*/

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*int A = 6;
int B = 7;
int C = 8;
if (A + B > C && B + C > A && C + A > B) Console.WriteLine("Существует!");
else Console.WriteLine("Не существует!");*/

/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

/*int number = Convert.ToInt32(Console.ReadLine());
int result = 1 ;
int result1 = 1;
int Fibonacci = 0;
Console.WriteLine(Fibonacci);
Console.WriteLine(result1);
Console.WriteLine(result1);
for (int i = 3; i < number; i++)
{
    Fibonacci = result + result1;
    result = result1;
    result1 = Fibonacci;
    Console.WriteLine(Fibonacci + " ");
}*/

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void СonversionBinary(int number)
{
    string result = "";
    while(number > 0)
    {
        result = number%2 + result;
        number/=2;
        // number = number / 2 
    }
    Console.WriteLine(result);
}

int inputNumber = Convert.ToInt32(Console.ReadLine());
СonversionBinary(inputNumber);

