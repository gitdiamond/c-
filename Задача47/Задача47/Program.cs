Console.WriteLine("Генерация массива:");
Console.WriteLine("Введите количество строк и столбцов массива:");
int firstt = Convert.ToInt32(Console.ReadLine());
int secondd = Convert.ToInt32(Console.ReadLine());
double[,] mainSort = Gen(firstt, secondd); ;

double[,] Gen(int first, int second)
{
    double[,] massiv = new double[first, second];
    for (int i = 0; i < first; i++)
    {
        for (int j = 0; j < second; j++)
        {
            massiv[i, j] = new Random().NextDouble() * 10;
            Console.Write($"{massiv[i, j]:f1}");
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    return massiv;
}


