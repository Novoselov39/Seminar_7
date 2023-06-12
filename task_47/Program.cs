Console.Clear();


double[,] RandomMass(int m, int n)
{
// //[1,0,1,1,0,1,0,0]
    double[,] array = new double[m,n];
    for (int i=0;i<m;i++)
    {
        for (int j = 0; j<n;j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble()*100,2);
        }
    }      
    return array;
}
void PrintMass(double[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }    
}

Console.Write("Выедите кол-во строк :");
int m = int.Parse(Console.ReadLine());
Console.Write("Выедите кол-во столбцов :");
int n = int.Parse(Console.ReadLine());
PrintMass(RandomMass(m,n));