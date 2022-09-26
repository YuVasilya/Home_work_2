//  Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
Console.Clear();
Console.WriteLine("Find arithmetic mean of seven numbers.");
int count = 7;
int[] array = new int[count];
Console.WriteLine("Given array:");
int index = 0;
int sum = 0;
while (index < count)
{
    array[index] = new Random().Next(1, 100);
    Console.Write(array[index] + " ");
    index += 1;
}
index = 0;
if (index < count)
{
    sum = sum+array[index];
    index += 1;
}

double mean = sum / count;
Console.Write("\nArithmetic mean of seven numbers ");
Console.WriteLine(mean);
