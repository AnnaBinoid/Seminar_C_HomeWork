/*
*Задача 60. ...
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

int rows3Matrix = 2;
int columns3Matrix = 4;
int pages3Matrix = 3
;

if (pages3Matrix *rows3Matrix * columns3Matrix <= 90)
{
    int[,,] our3Matrix = Create3Matrix(pages3Matrix, rows3Matrix, columns3Matrix);
    Print3Matrix(our3Matrix);
}
else Console.WriteLine ("This three-dimensional array is too large to fill it with two-digit numbers completely.");


int[,,] Create3Matrix(int pages, int rows, int columns )
{
    int[,,] threeMatrix = new int[pages, rows, columns];

    int number = 10;

    for (int i = 0; i < threeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < threeMatrix.GetLength(1); j++)
        {

            for (int k = 0; k < threeMatrix.GetLength(2); k++)
            {
                threeMatrix[i, j, k] = number++;
            }

        }
    }
    return threeMatrix;
}

void Print3Matrix(int[,,] threeMatrix)
{
    for (int i = 0; i < threeMatrix.GetLength(0); i++)
    {
        Console.WriteLine(String.Empty);
        for (int j = 0; j < threeMatrix.GetLength(1); j++)
        {
            Console.Write("[");
            for (int k = 0; k < threeMatrix.GetLength(2); k++)
            {
                Console.Write($"{threeMatrix[i, j, k],4}");
            }
            Console.WriteLine("  ]");
        }
    }
}
