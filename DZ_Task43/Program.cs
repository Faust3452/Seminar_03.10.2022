// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] IntersectionPoint(double bf, double kf, double bs, double ks)
{
    double[] res = new double[2];
    double x = (bs - bf) / (kf - ks);
    if (x == -0) x = 0;
    double y = kf * x + bf;
    res[0] = x;
    res[1] = y;
    return res;
}

Console.Write("Введите значения b1, k1, b2 и k2 для нахождения точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2\nВведите значение b1: ");
double bFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double kFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double bSecond = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double kSecond = Convert.ToDouble(Console.ReadLine());
if (kFirst == kSecond) Console.WriteLine("Точек пересечения нет");
else
{
    double[] result = IntersectionPoint(bFirst, kFirst, bSecond, kSecond);
    Console.WriteLine($"b1 = {bFirst}, k1 = {kFirst}, b2 = {bSecond}, k2 = {kSecond} -> ({result[0]}; {result[1]})");
}