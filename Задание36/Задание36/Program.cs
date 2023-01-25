//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных индексах.





void massiv()
{
    int[] mass = new int[10];
    int count = 0;
    Random rand = new Random();

    for (int i = 0; i < 10; i++)
    {
        mass[i] = rand.Next(0, 10);
        if (i % 2 == 1) count = count + mass[i];
    }

    Console.Write("Ваш массив:");

    for (int j = 0; j < 10; j++)
    {
        Console.Write(mass[j]);
        Console.Write(" ");

    }
    Console.WriteLine();
    Console.Write($"Сумма элементов, стоящих на нечётных индексах: {count}");

};

massiv();