// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите трёхзначное число, чтобы узнать третью цифру этого числа: ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
    if (Number<100)
    {
    Console.WriteLine("У этого числа нет третьей цифры");
    return;
    }
  Console.WriteLine("Итоговый результат: "+stringNumber[2]);