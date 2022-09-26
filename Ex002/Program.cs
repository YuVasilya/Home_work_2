// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Find third number");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Загадано число = ");
Console.WriteLine(N);
int index = 2;
string NText = Convert.ToString(N);
if (NText.Length>index)
{
Console.Write("Find number = ");
Console.WriteLine(NText[index]);
}
else
{
Console.WriteLine("Find number is not found");
}
Console.WriteLine("End");
/*if (N >= 100)
{
    int a = N / 100;
    int c = (N - a * 100) % 10;
    Console.WriteLine($"Thitd number: {c}");
}
Console.WriteLine("Thitd number is not found");*/