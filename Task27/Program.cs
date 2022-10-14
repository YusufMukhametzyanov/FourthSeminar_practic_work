/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
int double_number = number;
int summ = 0;

while (number > 0)
{
    int a = number % 10;
    number = number / 10;
    summ += a;

}

Console.WriteLine($"{double_number} -> {summ}");