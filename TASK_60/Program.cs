/*
Задача 60:
Сформируйте терхмерный массив 
из неповторяющийхся двухзначныхчисел. 
Напишите программу, которая будет построчно 
выводить массив ,добавляя индексы каждого элемента
*/

int[] numbers = new int[100];
int GetUniqNumber()
{
    bool uniq = false;
    int result = new int();
    while (!uniq)
    {
        result = new Random().Next(10, 100);
        if (numbers[result] == 0)
        {
            numbers[result] = 1;
            uniq = true;
            break;
        }
        else
        {
            int countUniq = GetNumberOfUniq(numbers);
            System.Console.WriteLine($"Повтор {countUniq}");
            if (countUniq==90)
            {
                System.Console.WriteLine("Все двухзначные числа использованы ");
                break;
            }
        }
    }
    return result;
}
int GetNumberOfUniq(int[] numbers)
{
    int result = new int();
    for (var i = 0; i < numbers.GetLength(0); i++)
    {
        if (numbers[i] == 1)
        {
            result++;
        }
    }
    return result;
}

int[,,] Generate3DAray(int rowsNumber, int colsNumber, int depthNumber)
{
    int[,,] result = new int[rowsNumber, colsNumber, depthNumber];
    for (int i = 0; i < rowsNumber; i++)
    {
        for (var j = 0; j < colsNumber; j++)
        {
            for (var z = 0; z < depthNumber; z++)
            {
                result[i, j, z] = GetUniqNumber();
            }
        }
    }
    return result;
}

void Print3DArray(int[,,] arrayToPrint, int oneLineLentgh = 3)
{
    int currentLenght = 0;
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (var z = 0; z < arrayToPrint.GetLength(2); z++)
            {
                System.Console.Write($"[{i},{j},{z}]: {arrayToPrint[i, j, z]}\t");
                if (currentLenght == oneLineLentgh)
                {
                    System.Console.WriteLine();
                    currentLenght = 0;
                }
                else
                {
                    currentLenght++;
                }
            }
        }
    }
}

const int rowsNumber = 5;
const int colsNumber = 5;
const int depthNumber = 3;
int[,,] generate3DAray = Generate3DAray(rowsNumber, colsNumber, depthNumber);
Print3DArray(generate3DAray);

