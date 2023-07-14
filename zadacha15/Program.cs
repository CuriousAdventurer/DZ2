// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7, обозначающее день, где 1 - Понедельник: ");
int ProverkaNaTupost=Convert.ToInt32(Console.ReadLine());
if (ProverkaNaTupost<0)
{
Console.WriteLine("От 1 до 7, гений...");
}
if (ProverkaNaTupost>7)
{
Console.WriteLine("От 1 до 7, гений...");
}
else
{
    if(ProverkaNaTupost<6)
    {
    Console.WriteLine("Пора вставать, трудяшка...");
    }
    else
    {
    Console.WriteLine("Поспи ещё, выходной!");
    }
}