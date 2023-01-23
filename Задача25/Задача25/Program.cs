//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//(Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)


void task()
{
    Console.WriteLine("Введите два числа, А и В:");
    int X = int.Parse(Console.ReadLine()!);
    int Y = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"A в степени B = {power(X,Y)}");
}


int power (int A,int B)
{
    int itog = 1;
    for (int i = 0; i < B; i++)
    {
        itog = itog * A;
    }
    return itog;      
}


task();
