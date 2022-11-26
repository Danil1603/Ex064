/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

void NumberCounter(int userNumber)
{
    if (userNumber < 0) Console.Write($"{userNumber} не натуральное число");
    if (userNumber == 0) return;
    Console.Write("{0,4}", userNumber);
    NumberCounter (userNumber - 1);
}

int userNumber = GetNumber("Введите число: ");
Console.WriteLine();
NumberCounter(userNumber);
