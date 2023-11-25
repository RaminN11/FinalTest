# Итоговая проверочная работа (1 блок)
## **Условия задачи**

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма _(можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)_
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом _(не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)_

**Задача:**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
```
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```
***
## **Решение**
### Блок схема:
> ![Alt text](<Снимок экрана (36).png>)

### Код для задачи на языке C#
```
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
 ```
