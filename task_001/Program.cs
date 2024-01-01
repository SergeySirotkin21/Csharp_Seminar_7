
// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

void OutputInt(int M, int N)
{
    int K = N -1;
    if (K < M) return;
    OutputInt(M, K);
    System.Console.Write(K + ", ");
}

//------
int M = ReadInt("Задайте число M: ");
int N = ReadInt("Задайте число N большее чем M: ");
while (N <= M)
{
    N = ReadInt("Не верно, задайте число N большее чем M: ");
}
OutputInt(M, N);
System.Console.Write(N);
