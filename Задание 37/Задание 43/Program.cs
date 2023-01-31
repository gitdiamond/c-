

void input()
{

    Console.WriteLine("Введите числа через пробел:");
    int[] massiv = aqua(Console.ReadLine()!);
    Console.WriteLine($"Количество чисел больше 0: {math(massiv)}");
};


int[] aqua(string stringname)
{
    string[] input = stringname.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[input.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(input[i]);
    }
    return result;

}
//
int math(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0) count++;
    }
    return count;
}

input();
