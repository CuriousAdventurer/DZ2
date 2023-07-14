// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int Prompt (string conditions) //https://learn.microsoft.com/en-us/dotnet/api/system.speech.synthesis.prompt?view=netframework-4.8.1
// {
// Console.Write(conditions);
// string meaning=Console.ReadLine(); //https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=net-7.0
// int result=Convert.ToInt32(meaning);
// return result;
// }
//тут проблем не должно быть

 int ThirdNumber(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
Console.Write("Введите число, состоящее из трех и более знаков: ");
int number1 = Convert.ToInt32(Console.ReadLine());
 
if (ThirdNumber(number1) == -1)
Console.WriteLine("Учимся считать до 3х, потом возвращаемся сюда.");
else
Console.WriteLine($"третий знак в числе: {ThirdNumber(number1)}");