//Задача 2: Напишите программу, которая на вход принимает два числа
//и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите 2 числа: ");
int x, y;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    Console.WriteLine($"Большее число х, х = {x}");
    Console.WriteLine($"Меньшее число y, y = {y}");
}

if (x < y)
{
    Console.WriteLine($"Большее число y, y = {y}");
    Console.WriteLine($"Меньшее число x, x = {x}");
}




