
Console.WriteLine("Введите количество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] mainSort = Gen(rows, columns);
average(mainSort, rows, columns);

int[,] Gen(int row, int column)
{
    int[,] mass = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            mass[i, j] = new Random().Next(0, 100);
            Console.Write($"{mass[i, j]} ");
        }
        Console.Write("\n");
    }

    return mass;
}


void average(int[,] mainSort1, int row, int column)
{


    for (int i = 0; i < column; i++)
    {
        int summ = 0;
        for (int j = 0; j < row; j++)
        {
            summ = summ + mainSort1[j, i];

        }
        summ = summ / row;
        Console.WriteLine($"Значение среднего арифмитического в первом столбце: {summ}");
    }

}