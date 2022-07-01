/*
Задача 67: Напишите программу, 
которая будет принимать на вход число 
и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/


void SumElementNumber(int number, int sum = 0)
{
    if (number == 0)
    {
        System.Console.WriteLine(sum);
    }
    if (number != 0)
    {
        sum = number % 10 + sum;
        number = number / 10;
        SumElementNumber(number, sum);
    }
}
SumElementNumber(45);
