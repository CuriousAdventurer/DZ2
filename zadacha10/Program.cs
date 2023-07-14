// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Отлично (ааааааааааааааа!!!!!): Если решены все задачи (компилируются, выполняются, выдают ожидаемый результат). 
//Числовые операции по выделению цифр сделаны при помощи операций “/” и “%”.

int Prompt (string conditions) //https://learn.microsoft.com/en-us/dotnet/api/system.speech.synthesis.prompt?view=netframework-4.8.1

{
System.Console.Write(conditions);
string meaning=Console.ReadLine(); //https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=net-7.0
int result=Convert.ToInt32(meaning);
return result;
}

int Number = Prompt("Введите трёхзначное число, чтобы узнать вторую цифру этого числа: ");
if (Number<100)
{
Console.WriteLine ("Учись считать до трех, солнышко!");
return;
}
if (Number>999)
{
Console.WriteLine ("Учись считать, солнышко!");
return;
}
int secondnumber=Number/10%10;
Console.WriteLine($"Второе число: "+secondnumber);
