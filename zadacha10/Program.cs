// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число, чтобы узнать вторую цифру этого числа: ");
int ThreeNumbersNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(ThreeNumbersNumber);
    if (ThreeNumbersNumber<100)
    {
    Console.WriteLine("Попробуй пересчитать количество цифр, недобор...");
    return;
    }
        if (ThreeNumbersNumber>999)
        {
        Console.WriteLine("Попробуй пересчитать количество цифр, перебор...");
        return;
        }
Console.WriteLine("Итоговый результат: "+stringNumber[1]);