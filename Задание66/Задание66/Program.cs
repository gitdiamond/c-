//Задача66 


Console.WriteLine("Введите первое число:");
int A = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine($"Сумма чисел между числами: {PowerdBy(A, B)}");


//-----------------method----------------------------------
int PowerdBy(int A, int B)
{
    int su   m = 0;
    while (A <= B)
    {
        sum = sum + A;
        A++;
        PowerdBy(A, B);
    }
    return sum;
}

