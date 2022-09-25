// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Find third number");
int N = new Random().Next(100, 1000);
Console.Write("Загадано число = ");
Console.WriteLine(N);
if (N >= 100)
{
    int a = N / 100;
    int c = (N - a * 100) % 10;
    Console.WriteLine($"Thitd number: {c}");
}
Console.WriteLine("Thitd number is not found");