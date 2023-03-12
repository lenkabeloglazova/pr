// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);

// вызов функции "сумма чисел от M до N"
void SumFromMToN(int m, int n)
{
    Console.Write (SumMN (m - 1, n));
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int= m;
    if (m == n)
        0 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
