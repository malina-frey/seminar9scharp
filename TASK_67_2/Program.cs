/*
Задача 67: Напишите программу, 
которая будет принимать на вход число 
и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int DigitSum (int number)
{
    if (number==0) return 0;
    return number %10 +DigitSum(number/10);
}
System.Console.WriteLine(DigitSum(453));