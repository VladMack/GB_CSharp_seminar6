using System;
using System.Linq;

Console.Clear();

int size = 10;

int[] array = new int[size].Select(x => new Random().Next(20)).ToArray();
Console.WriteLine(string.Join(", ", array));

int[] copyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < newArray.Length; i++)
        newArray[i] = arr[i];
    return newArray;
}

Console.WriteLine(string.Join(", ", copyArray(array)));