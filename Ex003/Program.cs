// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Сегодня выходной?");
int N = new Random().Next(1, 8);
Console.WriteLine($"N:{N}");
//bool holliday = false;
if (N > 5)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
Console.WriteLine("End");    