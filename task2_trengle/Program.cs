using System;
using System.Linq;

Console.Clear();

Console.WriteLine("Введи стороны треугольника через пробел:");
string[] trengle = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int num1 = int.Parse(trengle[0]);
int num2 = int.Parse(trengle[1]);
int num3 = int.Parse(trengle[2]);

Console.WriteLine((num1 < num2 + num3) && (num2 < num1 + num3) && (num3 < num2 + num1) ? "Такой треугольник может существовать." : "Такого треугольника быть не может.");