/*
Задача 65: 
Задайте значения M и N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/


void NuturalNumberMN(int numberM, int numberN, int current = 1)
{
    if (numberM < current)
    {
        return;
    }
    else
    {
        if (current >= numberN)
        {
            System.Console.Write(current);
            if (current < numberM)
            {
                System.Console.Write(", ");
            }
        }
        NuturalNumberMN(numberM, numberN, current + 1);

    }
}
NuturalNumberMN(5, 1);