//Задача 64

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(PowerdBy(N, 1));


//-----------------method----------------------------------
string PowerdBy(int N, int end)
{
    if (N == end) return N.ToString();
    return (N + " " + PowerdBy(N - 1, end));
}

