// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

/*
int GetAmountPositiveNumber(int howManyNumbers)
{
    int result = 0;
    for(int count = 0; count < howManyNumbers; count++)
    {
        Console.Write("Пожалуйста, введите число: ");
        if(Convert.ToInt32(Console.ReadLine()) > 0) result++;
    }
    return result;
}
Console.WriteLine("Данная программа подсчитывает количество положительных чисел.");
Console.Write("Пожалуйста, укажите сколько чисел вы собираетесь ввести: ");
int howManyNumbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество положительных чисел: {GetAmountPositiveNumber(howManyNumbers)}.");

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k2 * x + b2;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"Координаты точки пересечения двух прямых {x};{y}.");
*/
