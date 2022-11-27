// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2





double[] CreatrArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}



double DifferenceMinMax(double[] array)    // это отнело 2 часа моей жизни, подскажите есть ли более очевидный способ сразу найти мак и мин в массиве? 
{
    int minPosition = 0;
    int maxPosition = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

    }

    double result = array[maxPosition] - array[minPosition];
    return result;
}


double[] arr = CreatrArrayRndDouble(5, 1, 99);
PrintArray(arr);
double res = DifferenceMinMax(arr);
Console.Write( $" -> {res}");