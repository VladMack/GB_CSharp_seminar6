using System;
using System.Linq;

Console.Clear();
Console.WriteLine("Введи число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введи основание системы счисления:");
int basis = int.Parse(Console.ReadLine());

int convertNumber(int number, int found)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = (num % found).ToString() + result;
        num /= found;
    }
    return int.Parse(result);
}

Console.WriteLine(convertNumber(num, basis));