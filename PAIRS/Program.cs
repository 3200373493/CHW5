// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

void PairSum(int[] array)
{
    int j = array.Length - 1;
    int[] NewMass = new int[j];

    for (int i = 0; i < (array.Length + 1) / 2; i++)
    {
        if (i == j)
        {
            Console.Write(array[j]);
            break;
        }
        Console.Write(array[i] * array[j] + " ");
        // Console.Write($"[{String.Join(" ",array[i] * array[j])}]"); 
        j--;
    }

}

Console.Clear();
int[] Array1 = CreateRandomArray(123, 1, 1000);
ShowArray(Array1);
PairSum(Array1);