// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] MassFillRand(int range, int min, int max)
{
    int[] arr = new int[range];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

int[] CopyArr(int[] arr)
{
    int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];        
    }
    return copy;
}

Console.WriteLine("Введите размер массива: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max: ");
int mx = Convert.ToInt32(Console.ReadLine());
int[] array = MassFillRand(s, mn, mx);
Console.Write("Случайно сгенерированный массив: ");
PrintArray(array);
int[] copyArr = CopyArr(array);
Console.Write("Копия сгенерированного массива:  ");
PrintArray(copyArr);
