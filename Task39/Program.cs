// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

//Array.Reverse() - метод разворота массива

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

void ReverseArrayWhile(int[] arr)
{
    int size = arr.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int obj = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = obj;
        index1++;
        index2--;
    }
}

void ReverseArrayFor(int[] arr)
{
    int size = arr.Length;
    for (int index = 0; index < size / 2; index++)
    {
        int obj = arr[index];
        arr[index] = arr[size - 1 - index];
        arr[size - 1 - index] = obj;        
    }
}

Console.WriteLine("Введите размер массива: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max: ");
int mx = Convert.ToInt32(Console.ReadLine());

int[] array = MassFillRand(s, mn, mx);
Console.Write("Сгенерированный массив: ");
PrintArray(array);
//ReverseArrayWhile(array);
//Array.Reverse(array);
ReverseArrayFor(array);
Console.Write("Развернутый массив:     ");
PrintArray(array);

