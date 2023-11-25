// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



    
        
// Console.WriteLine("Введите элементы массива через запятую:");
// string input = Console.ReadLine();
// string[] inputArray = input.Split(',');

// int count = 0;
// for (int i = 0; i < inputArray.Length; i++)
//     {
//         if (inputArray[i].Length <= 3)
//         {
//             count++;
//         }
//     }

        
// string[] newArray = new string[count];
// int index = 0;
// for (int i = 0; i < inputArray.Length; i++)
// {
//     if (inputArray[i].Length <= 3)
//     {
//         newArray[index] = inputArray[i];
//         index++;
//     }
// }

        
// Console.WriteLine("Новый массив строк, длина элементов которых <= 3:");
// for (int i = 0; i < newArray.Length; i++)
// {
//     Console.WriteLine(newArray[i]);
// }
using System;

class Program
{
static void Main(string[] args)
{
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
        
    string[] array = new string[size]; 
        
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива {i + 1}: ");
        array[i] = Console.ReadLine(); 
    }
        
    string[] newArray = new string[size];
    int count = 0; 
        
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[count] = array[i]; 
            count++; 
        }
    }
        
    Console.WriteLine("Новый массив:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(newArray[i]); 
    }
}
}
 