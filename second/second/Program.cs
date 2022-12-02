//Задача 4: Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.


int[] a=new int[3];
int max;

Console.WriteLine("Введите 3 числа: ");

for(int i = 0; i < 3; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
};

max = a[0];

for (int j = 0; j<3; j++)
{
    if (a[j] > max) max = a[j];
};

Console.WriteLine($"Максимальное число из введенных: {max}"); 
