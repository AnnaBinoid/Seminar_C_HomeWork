/*
15. Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот 
день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Please, enter the number from 1 till 7 : ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 8 && userNumber > 0)
{
    string answer = WeekdayOrWeekend(userNumber);
    Console.WriteLine(answer);
}
else Console.WriteLine($"Number {userNumber} is not from 1 till 7. Try again!");

string WeekdayOrWeekend(int number)
{
    return userNumber > 0 && userNumber < 6 ? "No. (Poor you, it's a weekday.)" : "Yes. (Lucky you! It' s a weekend! Have fun!";
}
