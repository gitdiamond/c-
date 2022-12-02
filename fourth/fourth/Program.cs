//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N


int N;
Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N+1; i++)
{
    if (i % 2 == 0) Console.WriteLine(i);
    
};