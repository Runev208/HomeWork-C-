// Домашняя работа по Cеминару 4

// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

*/

// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int[] CreateArray(int length)
{
    int[] array = new int[length];

    for(int i = 0; i < length; i++)
    {
        Console.Write($"Input a {i + 1} element: ");
        array[i]= Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array) 
{ 
    Console.Write("Your array is " ); 
    for (int i = 0; i < array.Length - 1; i++) 
        Console.Write(array[i] + " | "); 
    Console.Write($"{array[array.Length - 1]}"); 
    Console.WriteLine(); 
}
Console.WriteLine("Please input a length of array");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(m);
ShowArray(array);
*/
