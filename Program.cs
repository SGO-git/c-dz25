// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m1, int n1)
{
    if (m1 == n1) return m1;
    return m1 + SumNumbers(m1 + 1, n1);

}

int m = ReadInt("Input number M ");
int n = ReadInt("Input number N ");
if (m < n)
{
    System.Console.WriteLine(SumNumbers(m, n));
}
else
{
    System.Console.WriteLine(SumNumbers(n, m));
}