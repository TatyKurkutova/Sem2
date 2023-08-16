/* Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int thirddDigit = number % 10;
if (number % 100 != 0 && number <= 999 && number > 99)
    Console.WriteLine($"Третья цифра в цисле {number} равна {thirddDigit}");
else
    Console.WriteLine($"В цисле {number} нет третьей цифры");

