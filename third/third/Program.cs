
//Задача 6: Напишите программу, которая на вход принимает число и 
//выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число: ");
int x;
x = Convert.ToInt32(Console.ReadLine());
if (x % 2==0)  Console.WriteLine("Число чётное");
else 
            Console.WriteLine("Число нечётное");


