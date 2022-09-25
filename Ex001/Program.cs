// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("This Program find second number.");
int N = new Random().Next(100, 1000);
Console.Write("Загадано число = ");
Console.WriteLine(N);
int a = N/100;
int b = (N - a*100)/10;
Console.WriteLine($"Second number: {b}");