
// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29


int ReadInt(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
// Функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ( n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m, n -1));
}

//------
int m = ReadInt("Введите значение числа m: ");
int n = ReadInt("Введите значение числа n: ");
System.Console.WriteLine("Значение функции Аккермана =" +" "+ Akkerman(m, n));

