// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreatrArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int EvenNumbers(int[] array)
{
    int evens = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evens += 1;
    }
    return evens;
}

int[] arr = CreatrArrayRndInt(10, 100, 1000);

int result = EvenNumbers(arr);
PrintArray(arr);
Console.Write($" -> {result}");

