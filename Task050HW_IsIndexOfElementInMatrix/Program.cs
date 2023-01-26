/*
Задача 50. 
Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого элемента в массиве нет
*/

Console.WriteLine("Please, enter coordinates of element!");
Console.WriteLine("Enter the number of row: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of column: ");
int userColumn = Convert.ToInt32(Console.ReadLine());

if (userRow > 0 && userColumn > 0)
{
    int minRandValue = 1;
    int maxRandValue = 11;
    int[,] matrixRand = CreateMatrixRand(minRandValue, maxRandValue);
    PrintMatrix(matrixRand);

    if (IsElementInMatrix(matrixRand, userRow, userColumn)) Console.WriteLine($"The value of element on {userRow} row and {userColumn} column is {matrixRand[userRow - 1, userColumn - 1]}.");
    else Console.WriteLine($"There is no element with coordinates {userRow}, {userColumn}, try again!");
}
else Console.WriteLine($"One or both of your numbers ({userRow}, {userColumn}) are less than 0 or equal to 0. Please, try again!");

int[,] CreateMatrixRand(int min, int max)
{
    Random rnd = new Random();
    int rows = rnd.Next(min, max);
    int columns = rnd.Next(min, max);
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

bool IsElementInMatrix(int[,] matrix, int row, int column)
{
    if (row > matrix.GetLength(0) || column > matrix.GetLength(1)) return false;
    else return true;
}

