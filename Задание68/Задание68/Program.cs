//Функция Аккермана

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine($"Функция Аккермана: {PowerdBy(m, n)}");


//-----------------method----------------------------------
int PowerdBy(int m, int n)
{
    if (m == 0) return n + 1; 
    if (m > 0 && n == 0) return PowerdBy(m - 1, n); 
    if (m > 0 && n > 0) return PowerdBy(m - 1, PowerdBy(m, n - 1));
    return PowerdBy(m, n);
}

