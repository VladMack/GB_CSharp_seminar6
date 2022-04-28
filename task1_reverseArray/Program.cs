using System;
using System.Linq;

Console.Clear();

int size = 10;

int[] array = new int[size].Select(x => new Random().Next(20)).ToArray();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", array.Reverse()));
Console.WriteLine(string.Join(", ", array));


for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}

Console.WriteLine(string.Join(", ", array));

int[] newArray = new int[array.Length];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[array.Length - 1 - i];
}

Console.WriteLine(string.Join(", ", newArray));