﻿// Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] FindSizeText (string[] array, int num)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < num) result = result + array[i] + " ";
    }
    string[] newArray = result.Split();
    return newArray;
}

Console.Clear();
Console.WriteLine("Введите слова через пробел: ");
string mass = (Console.ReadLine()!);
int n = 4;
string[] arr = mass.Split();
Console.WriteLine($"Слова длина которых меньше, либо равна 3 символам: [{string.Join(", ", FindSizeText(arr, n))}]");


