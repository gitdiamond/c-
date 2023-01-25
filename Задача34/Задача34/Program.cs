//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2



void massiv()
{
    int[] mass = new int[10];
    int count = 0;
    Random rand = new Random();

    for (int i = 0; i < 10; i++)
    {
        mass[i] = rand.Next(100, 1000);
        if (mass[i] % 2 == 0) count++;
    }

    Console.Write("Ваш массив:");

    for (int j = 0; j < 10; j++)
    {
        Console.Write(mass[j]);
        Console.Write(" ");
        Console.Write(" ");
    }
    Console.Write($"Количество чётных чисел: {count}");

};

massiv();