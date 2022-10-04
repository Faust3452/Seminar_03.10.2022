// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
int PositiveCount(string s)
{
    int count = 0;
    string[] num = s.Split(",");
    for (int i = 0; i < num.Length; i++)
    {
        int tmp = Convert.ToInt32(num[i]);
        if (tmp > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите числа через запятую. Например: 0,3,4,5,6,7,-6. ");
string input = Console.ReadLine();
int result = PositiveCount(input);
Console.WriteLine($"{input} -> {result}");