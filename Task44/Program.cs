// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
void FiboN(int num)
{
    int fib1 = 0;
    int fib2 = 1;
    int fibPrev = default;
    int fibPrevPrev = default;
    int fib = default;
    for (int i = 0; i < num; i++)
    {
        if (i == 0) 
        {
            Console.Write($"{fib1} ");
            fibPrevPrev = fib1;
        }
        else
        {
            if (i == 1) 
        {
            Console.Write($"{fib2} ");
            fibPrev = fib2;
        }
        else
        {
            fib = fibPrev + fibPrevPrev;
            Console.Write($"{fib} ");
            int tmp = fibPrev;
            fibPrev = fib;
            fibPrevPrev = tmp;
        }
        }
    }
}


Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
FiboN(a);