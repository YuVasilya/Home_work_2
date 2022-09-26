// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Сегодня выходной?");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N:{N}");
if (N == 6 || N == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
if (N < 1|| N > 7) 
{
    Console.WriteLine("Это не день недели");
}
Console.WriteLine("End");