
//Напишите программу, которая задаёт массив из 8 элементов и
//выводит их на экран. (числа берете любые)



void massiv()
{
    int[] mass = new int[8];
    Random rand = new Random();

    for (int i = 0; i < 8; i++)
    {
        mass[i] = rand.Next(100000);
    }

    Console.Write("Ваш массив:");

    for (int j = 0; j < 8; j++)
    {
        Console.Write(mass[j]);
        Console.Write(" ");
    }
};

massiv();
