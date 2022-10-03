// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool CheckTriangle(int arg1, int arg2, int arg3)
{
    if ((arg1 < arg2 + arg3) && (arg2 < arg1 + arg3) && (arg3 < arg2 + arg1)) return true;
    else return false;
}

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
bool check = CheckTriangle(a, b, c);
if (check == true) Console.WriteLine("Треугольник возможен!");
else Console.WriteLine("Треугольник невозможен!");