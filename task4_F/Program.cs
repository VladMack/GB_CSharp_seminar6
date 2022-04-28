using System;
using System.Linq;

Console.Clear();
Console.WriteLine("Введи число:");
int num = int.Parse(Console.ReadLine());
int[] fib = new int[num];
fib[0] = int.Parse(Console.ReadLine());
fib[1] = int.Parse(Console.ReadLine());
for (int i = 2; i < fib.Length; i++)
{
    fib[i] = fib[i - 1] + fib[i - 2];
}

Console.WriteLine(string.Join(" ", fib));