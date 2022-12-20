/*
13. Напишете программу, которая выодит третью цифру
заданного числа, или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Enter your number, please : ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 100 && userNumber > -100)
{
    Console.WriteLine($"There is no third digit in number {userNumber}.");
}
else
{
    int ourNumber = ThirdDigit(userNumber);
    Console.WriteLine($"Third digit from number {userNumber} is {ourNumber}.");
}

int ThirdDigit(int num)
{
    while (num > 1000 || num < -1000)
    {
        num = num / 10;
    }

    num = Math.Abs(num % 10);
    return num;
}