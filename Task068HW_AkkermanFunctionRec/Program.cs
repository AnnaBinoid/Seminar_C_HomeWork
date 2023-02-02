/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m = 3;
int n = 3;


Console.Write($"For numbers {m}, {n} the value of Akkerman function is {AkkermanFunction(n, m)}.");


int AkkermanFunction(int NumN, int NumM)
{
    if (NumN == 0) return NumM + 1;
    else if (NumN != 0 && NumM == 0) return AkkermanFunction(NumN - 1, 1);
    else if (NumN > 0 && NumM > 0) return AkkermanFunction(NumN - 1, AkkermanFunction(NumN, NumM - 1));
    return AkkermanFunction(NumN, NumM);
}