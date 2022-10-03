// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int[] TransferToBin(int num)
{
    int size = 0;
    int tmp = num;
    while (tmp > 1)
    {
        tmp = tmp / 2;
        size ++;
    }
    size += 1;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = num % 2;
        num = num / 2;
    }
    Array.Reverse(result);
    return result;
}

string TransferToBin2(int num)
{
    string result = default;
    while(num > 1)
    {
        result = result + (num % 2);
        num = num / 2;
    }
    result = result + num;
    return result;
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

void TransferToBin3(int num)
{
    if (num == 0) return;
    TransferToBin3(num / 2);
    Console.Write(num % 2);
}

string ReverseString(string s)
{
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] bin = TransferToBin(a);
Console.Write("Двоичное представление: ");
PrintArray(bin);
string res = ReverseString(TransferToBin2(a));
Console.Write($"Двоичное представление: {res}");
Console.WriteLine();
TransferToBin3(a);
