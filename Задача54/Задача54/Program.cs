Console.WriteLine("Введите количество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] mainSort = Gen(rows, columns);
int[,] mainsSort2= Gen(rows, columns);
int[,] mainSort3= Gen(rows, columns);
print(mainSort); 
print(mainsSort2);
print(mainSort3);



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


void print(int[,] mainSort1)
{
    Console.WriteLine();
    Console.WriteLine();

    for (int i = 0; i < mainSort1.GetLength(0); i++)
    {
        for (int j = 0; j < mainSort1.GetLength(1); j++)
        {
            Console.Write($"{mainSort1[i, j]} ");
        }
        Console.Write("\n");
    }

}

/*
int[,] result(int rows, int columns)
{
    int k = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j=0;j<columns; j++)
        {
            for(int v = 0; v < rows; v++)
            {
                mainSort3[i, j] = mainSort[i, j] * mainSort2[v, j];
            }
        }
    }

    return mainSort3;
}

*/