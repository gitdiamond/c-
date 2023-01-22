

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


using System.Diagnostics.Metrics;

void task()
{
    Console.WriteLine("Введите число:");
    int X = Int32.Parse(Console.ReadLine()!);
    int buff1 = GetQuantity(X);
    Console.WriteLine($"Сумма чисел введенного числа: {power(X, buff1)}");
}

int GetQuantity(int A)
{
    int Quantity = 0;
    while (A > 0)
    { Quantity = Quantity + 1; A = A / 10; }
    return Quantity;
}



int power(int B, int buff1)
{

    int advance = 0;
    int result = 0;
    for (int i = 0; i < buff1; i++)
    {
        advance = B - B % 10;
        result = result + (B - advance);
        B = B / 10;
    }
    return result;

}

task();


