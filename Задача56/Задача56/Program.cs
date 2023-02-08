/*Console.WriteLine("Введите количество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] mainSort = Gen(rows, columns);
find(mainSort);

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


void find(int[,] mainSort1)
{
    int[] mass2 = new int[mainSort.GetLength(0)];


    for (int i = 0; i < mainSort1.GetLength(0); i++)
    {

        int sum = 0;
        for (int j = 0; j < mainSort1.GetLength(1); j++)
        {
            sum = sum + mainSort1[i, j];
        }
        mass2[i] = sum;
    }

    int min = mass2[0];
    int index = 0;

    for (int i = 0; i < mass2.GetLength(0); i++)
    {
        if (mass2[i] < min)
        {
            min = mass2[i];
            index = i;

        }
    }

    Console.WriteLine();
    Console.Write($"Строка с наименьшей суммой элементов: {index+1}");

}*/


Console.WriteLine("Введите количество строк в первом массиве:");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в первом массиве:");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк во втором массиве:");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов во втором массиве:");
int columnsB = Convert.ToInt32(Console.ReadLine());

if (rowsA != columnsB)
{
    Console.WriteLine("Такие матрицы невозможно умножить!");
    return;
}

int[,] matrixA = Gen(rowsA, columnsA);
int[,] matrixB = Gen(rowsB, columnsB);
print(matrixA);
Console.WriteLine(matrixB); 
print(matrixB);
Console.WriteLine(matrixB);
int[,] matrixC = result(matrixA, matrixB);
print(matrixC);




int[,] Gen(int row, int column)
{
    int[,] mass = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            mass[i, j] = new Random().Next(0, 100);
        }
        
    }

    return mass;
}


void print(int[,] mainSort1)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Результат умножения матрциц:");
    Console.WriteLine("Результат умножения матрциц:");

    for (int i = 0; i < mainSort1.GetLength(0); i++)
    {
        for (int j = 0; j < mainSort1.GetLength(1); j++)
        {
            Console.Write($"{mainSort1[i, j]} ");
        }
        Console.Write("\n");
    }

}


int[,] result(int[,] matrix, int[,] matrix1)
{
    int[,] matrixC = new int[matrix.GetLength(0), matrix1.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrixC[i, j] = matrixC[i,j] +  matrix[i, k] * matrix1[k, j];
            }
        }
    }

    return matrixC;
}





