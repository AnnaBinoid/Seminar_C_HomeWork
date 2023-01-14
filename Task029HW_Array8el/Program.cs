/*Напишите программу, 
которая задаёт массив из 8 элементов и 
выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

int arrayLength = 8;
int[] array = CreateArray(arrayLength);
FillArray(array);

String output = PrintArray(array);
Console.WriteLine($"{output} -> [{output}]");
//PrintArray(array);


int[] CreateArray(int length)
{
    return new int[length];
}

void FillArray(int[] myArray)
{
    Random rnd = new Random();

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(1, 100);
    }
}

/*void PrintArray (int[] ohMyArray)
{
    for (int i = 0; i < ohMyArray.Length-1; i++)
    {
        Console.Write(ohMyArray[i] + ", ");
    }
    Console.Write(ohMyArray[ohMyArray.Length-1] + " -> [" );
    for (int j = 0; j < ohMyArray.Length-1; j++)
    {
        Console.Write(ohMyArray[j] + ", ");
    }
    Console.Write(ohMyArray[ohMyArray.Length-1] + "]");
}*/

String PrintArray (int[] ohMyArray)
{
    string s = String.Join(", ", ohMyArray);
    return s;
}