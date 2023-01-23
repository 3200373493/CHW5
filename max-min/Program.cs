//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Max_Min(int[] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 0; i < (array.Length); i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.Write($"РАЗНИЦА МАКСИМАЛЬНОГО И МИНИМАЛЬНОГО ЧИСЕЛ МАССИВА = {max - min}");
}

Console.Clear();
int[] Array1 = CreateRandomArray(7, 1, 100);
ShowArray(Array1);
Max_Min(Array1);