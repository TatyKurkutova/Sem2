/* Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

using System.Globalization;

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
int second = n / 10 % 10;
Console.WriteLine ($"Вторая цифра в цисле {n} равна {second}");