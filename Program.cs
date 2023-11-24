/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы исходного массива (через запятую, после ввода елементов нажмите enter):");
        string[] sourceArray = Console.ReadLine().Split(',');

        string[] newArray = new string[sourceArray.Length];
        int newIndex = 0;
  
  for (int i = 0; i < sourceArray.Length; i++)
        {
            if (sourceArray[i].Length <= 3)
            {
                newArray[newIndex] = sourceArray[i];
                newIndex++;
            }
        }

        Array.Resize(ref newArray, newIndex);

        Console.Write($"[\"{string.Join("\",\"", sourceArray)}\"] → ");
        Console.WriteLine($"[\"{string.Join("\",\"", newArray)}\"]");
        
      
    }
}
