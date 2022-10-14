/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());
int result = a;

for (int i = 1; i < b; i++)
{
    result *= a;
}
Console.WriteLine($"{a}, {b} -> {result}");
// double result = Math.Pow(a, b);
// Console.WriteLine($"{result}");