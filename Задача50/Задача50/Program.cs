
Console.WriteLine("Введите количество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое нужно найти в массиве:");
int find = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] mainSort = Gen(rows, columns);
search(mainSort, rows, columns, find);

int[,] Gen(int row, int column)
{
    int[,] mass = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            mass[i, j] = new Random().Next(-20, 100);
            Console.Write($"{mass[i, j]} ");
        }
        Console.Write("\n");
    }

    return mass;
}


void search(int[,] mainSort1, int row, int column, int findi)
{
    int check = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (mainSort1[i, j] == findi)
            {
                check = 1;
                break;
            }

        }
    }

    if (check == 1)
    {
        Console.WriteLine("Данное число найдено в массиве");

    }

    else if (check == 0)
    {
        Console.WriteLine("Данное числе не найдено в массиве");
    }


}