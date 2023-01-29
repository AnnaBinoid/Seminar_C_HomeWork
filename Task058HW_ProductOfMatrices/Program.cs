/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

//int matrixRows = 4;
//int matrixColumns = 4;
int minValue = 1;
int maxValue = 11;
int minMatrixSize = 2;
int maxMatrixSize = 6;

int[,] firstMatrix = CreateMatrix(minMatrixSize, maxMatrixSize, minValue, maxValue);
PrintMatrix(firstMatrix);
Console.WriteLine(String.Empty);
int[,] secondMatrix = CreateMatrix(minMatrixSize, maxMatrixSize, minValue, maxValue);
PrintMatrix(secondMatrix);
Console.WriteLine(String.Empty);

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] productOfMatrices = ProductOfMatrices(firstMatrix, secondMatrix);
    PrintMatrix(productOfMatrices);
}
else Console.WriteLine("Мatrix multiplication is not possible because the number of columns in the 1 matrix is not equal to the number of rows in the 2 matrix.");


int[,] CreateMatrix(int minSize, int maxSize, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rnd.Next(minSize, maxSize), rnd.Next(minSize, maxSize)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return (matrix);
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine($"]", 4);
    }
}

int[,] ProductOfMatrices(int[,] first, int[,] second)
{
    int[,] product = new int[first.GetLength(0), second.GetLength(1)];

    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            product[i, j] = 0;

            for (int k = 0; k < first.GetLength(1); k++)
            {
                product[i, j] = product[i, j] + first[i, k] * second[k, j];
            }
        }
    }
    return product;
}
