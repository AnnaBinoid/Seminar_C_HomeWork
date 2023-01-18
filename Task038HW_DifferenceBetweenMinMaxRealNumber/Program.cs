/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/
int myArraySize = 5;
int min = 1;
int max = 100;

double[] myArray = CreateArray(myArraySize, min, max);
PrintArray(myArray);

double maxDouble = MaxDouble(myArray);
double minDouble = MinDouble(myArray);
double diffMaxMin = DifferenceMaxMinRealNumber(maxDouble, minDouble);

Console.WriteLine($"The difference between max ({maxDouble}) and min ({minDouble}) numbers in array is {diffMaxMin}.");


double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine (arr[i]);
    }
}

double MaxDouble(double[] arrMax)
{
    double maximumDouble = arrMax[0];

    for (int i = 1; i < arrMax.Length; i++)
    {
        if (arrMax[i] > maximumDouble) maximumDouble = arrMax[i];
    }
    return maximumDouble;
}

double MinDouble(double[] arrMin)
{
    double minimumDouble = arrMin[0];
    for (int i = 1; i < arrMin.Length; i++)
    {
        {
            if (arrMin[i] < minimumDouble) minimumDouble = arrMin[i];
        }
    }
    return minimumDouble;
}

double DifferenceMaxMinRealNumber(double max, double min)
{
    double diff = max - min;
    return Math.Round(diff, 1);
}