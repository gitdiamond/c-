
Console.WriteLine("Генерация массива:");
int[] mainSort = Gen();
Sort(mainSort);
print(mainSort);

int[] Gen()
{
    int value = new Random().Next(5, 10);
    int[] massiv = new int[value];
    for (int i = 0; i < value; i++)
    {
        massiv[i] = new Random().Next(0, 100);
        Console.Write(massiv[i]);
        Console.Write(" ");
    }
    return massiv;
}
//
void Sort(int[] array)
{
    int buff;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                buff = array[i];
                array[i] = array[j];
                array[j] = buff;
            }
        }
    }

}

void print(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Отсортированный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
}
