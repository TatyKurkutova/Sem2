/* Задача 15: Напишите программу, 
которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// string [] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
// Console.WriteLine (days [n-1]);

Console.Clear();
int Week(string message)
{
    Console.Write(message);
    int day = int.Parse(Console.ReadLine()!);
    return day;
}

void Day(int day)
{
    if (day <= 5)
    {
        Console.WriteLine("Будний день.");
    }
    else
    {
        Console.WriteLine("Выходной день.");
    }
}

int day = Week("Введите цифру, обозначающую день недели (от 1 до 7): ");
Day(day);



