// Написать программу, 
// которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно  массивами.


string[] arrayStr = CreateArray();

int minElement = MinElementInArray(arrayStr);

string[] arrayStr2 = CreateNewArray(minElement, arrayStr);

Console.WriteLine($"[{PrintArray(arrayStr)}] -> [{PrintArray(arrayStr2)}]");

string[] CreateArray()
{
    string[] array;
    Console.Write("Задайте размер массива - ");
    int x = int.Parse(Console.ReadLine());
    array = new string[x];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение массива которое хотите сохранить под индексом {i} -> ");
        array[i]  = Console.ReadLine();
    }
    Console.WriteLine();
    return array;
}

int MinElementInArray(string[] arrayStr)
{
    int count = 0;
    for (int i = 0; i < arrayStr.Length; i++)
    {
        if (arrayStr[i].Length <= 3)  count++;
    }
    return count;
}

string[] CreateNewArray(int minElement, string[] arrayStr)
{
    string[] array = new string[minElement];
    int j = 0;
    for (int i = 0; i < arrayStr.Length; i++)
    {
        if (arrayStr[i].Length <= 3)
        {
            array[j] = arrayStr[i];
            j++;
        }
    }
    return array;
}

string PrintArray(string[] array)
{
    return ($"{string.Join(" ", array)}");
}
