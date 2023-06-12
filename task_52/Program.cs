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

void AvrageColum(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        Console.WriteLine($"среднее стобаца №{i + 1} равно: {sum / array.GetLength(0)}");
    }
}

Console.Write("Выедите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Выедите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = RandomMass(m, n);
PrintMass(array);
AvrageColum(array);