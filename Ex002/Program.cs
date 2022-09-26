// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Find third number");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Загадано число = ");
Console.WriteLine(N);

string NText = Convert.ToString(N);
if (NText.Length>2)
{
Console.Write("third number = ");
Console.WriteLine(NText[2]);
}
else
{
Console.WriteLine("Third numberis not found");
}
Console.WriteLine("End");
/*if (N >= 100)
{
    int a = N / 100;
    int c = (N - a * 100) % 10;
    Console.WriteLine($"Thitd number: {c}");
}
Console.WriteLine("Thitd number is not found");*/