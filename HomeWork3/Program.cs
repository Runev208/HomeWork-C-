// Домашняя работа по Cеминару 3

// Задача 1.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

/*
int getDigitAtPosition(int number, int position)
{
    int index = 5 - position;

    if (index < 0 || index > 4)
    {
        return 0;
    }
    if (index == 0)
    {
        return number % 10;
    }
    int modulo = Convert.ToInt32(Math.Pow(10, index + 1));
    int divider = Convert.ToInt32(Math.Pow(10, index));

    return (number % modulo) / divider;
}

bool isPalindrome(int num)
{
    for (int position = 1; position <= 2; position++)
    {
        int digit = getDigitAtPosition(num, position);
        int mirroredDigit = getDigitAtPosition(num, 6 - position);
        if (digit != mirroredDigit)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Введите пятизначное число");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Недопустимое значение");
}
else
{
    if (isPalindrome(num))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

*/

// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

/*


*/

// Задача 3. 
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

/*


*/