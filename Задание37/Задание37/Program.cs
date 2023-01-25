//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и
//последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве..





using System.Runtime.InteropServices;

void massiv()
{
    int[] mass = new int[10];
    int[] mass2 = new int[5];
    Random rand = new Random();
    int k = 9;

    for (int i = 0; i < 10; i++)
    {
        mass[i] = rand.Next(0, 10);
    }

    Console.Write("Ваш массив:");

    for (int j = 0; j < 10; j++)
    {
        Console.Write(mass[j]);
        Console.Write(" ");

    }


    for (int i = 0; i < 5; i++)
    {
        mass2[i] = mass[i] * mass[k];
        k--;

    }

    Console.WriteLine();
    Console.WriteLine("Ваш новый массив:");

    for (int i = 0; i < 5; i++)
    {
        Console.Write(mass2[i]);
        Console.Write(" ");
    }

};

massiv();