
// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


// Функция ввода числа 
int ReadInt(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
// Функция заполнения мвссива
int[] GenerateMatrix(int size, int leftRange, int rightRange)
{   
    int[] matrix = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        matrix[i] = rand.Next(leftRange, rightRange + 1);
    }
    return matrix;
}

// Функция реверса печати массива
void RevPrint(int[] matrix, int i = 0)
{ 
    if (i >= matrix.Length) return;
    RevPrint(matrix, i + 1);
    Console.Write(matrix[i] + "  ");
}


//------
int size = ReadInt("Задайте длинну массива: ");
int[] myMatrix = GenerateMatrix(size, 10, 50);
Console.Write("[" + string.Join(", ", myMatrix) +"] => ");
RevPrint(myMatrix);
