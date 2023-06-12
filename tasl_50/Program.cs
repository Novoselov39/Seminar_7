Console.Clear();


int[,] RandomMass(int m, int n)
{
    // //[1,0,1,1,0,1,0,0]
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(100);
        }
    }
    return array;
}
void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Searh(int[,] array, int m, int n)
{
    if (array.GetLength(0) >= (m-1) && array.GetLength(1) >= (n-1))
    {
        Console.WriteLine($"Искомое число: {array[m-1,n-1]}");
    }
    else Console.WriteLine("Такого числа нет");
}



int a = new Random().Next(10);
int b = new Random().Next(10);
int[,] array = RandomMass(a, b);
PrintMass(array);
Console.Write("Введите номер строки: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Выедите номер столбца: ");
int n = int.Parse(Console.ReadLine());
Searh(array,m,n);
