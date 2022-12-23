// Домашняя работа по Cеминару 2

// Задача 1.
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int cutnumber(int number) 
{
 int ten = number / 10;
 int remainder = ten % 10;
 return remainder;
}
Console.WriteLine("Please input your number ");
int number = Convert.ToInt32(Console.ReadLine());
if((-999 <= number && number <= -100) || (number <= 999 && number >= 100 && number != 0))
{
    if (1 <= number && number <= 999)
    {
    Console.WriteLine($"Second number is " + (cutnumber(number)));
    }
    else
    {
    Console.WriteLine($"Second number is " + (-1 *(cutnumber(number))));
    }
}
else
{
    Console.WriteLine("Please input correct number");
}
*/

// Задача 2.
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int cutnumber(int number)
{
    while (number > 999 || number < -999)
    {
    number = number / 10;
    }
    number = number % 10;
    return number;  
}
int plus(int number)
{
  while(number < 0)
  {
    number = -1 * number;
  }
  return number;
}
Console.WriteLine("Please input your number ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 || number <= -100 && number != 0)
{ 
    number = plus(number);
    Console.WriteLine($"Third number is {cutnumber(number)}");
}
else
{
    Console.WriteLine("Please input correct number");
}
*/

// Задача 3.