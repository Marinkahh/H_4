// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма чисел = {SumNums(num)}");

int SumNums(int number)
{
    int sum = 0;
    while (number >= 1)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}