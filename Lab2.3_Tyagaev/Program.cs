//Лабораторная работа 2.3; Вариант: 9; Сложность: Средняя;

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
double y = 0;
switch (n)
{
    case 1:
        {
            double z = Math.Exp(x);
            double a = 1.2; double b = 7.2;
            if (x < Math.Pow(x, 3)) y = (a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x + a));
            else if ((Math.Pow(a, 3) <= x) && (x <= b)) y = ((Math.Pow((a + b * x), 2) - Math.Sin(a + z * x)));
            else if (x > b) y = (Math.Sqrt(x - (Math.Sin((b * x + z)))));
        }
        break;
    case 2:
        {
            double z = Math.Exp(2 * x);
            double a = -1.5; double b = 3.2;
            if (x < Math.Pow(x, 3)) y = (a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x + a));
            else if ((Math.Pow(a, 3) <= x) && (x <= b)) y = ((Math.Pow((a + b * x), 2) - Math.Sin(a + z * x)));
            else if (x > b) y = (Math.Sqrt(x - (Math.Sin((b * x + z)))));
        }
        break;
    case 3:
        {
            double z = Math.Exp(3);
            double a = 1.7; double b = 5.5;
            if (x < Math.Pow(x, 3)) y = (a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x + a));
            else if ((Math.Pow(a, 3) <= x) && (x <= b)) y = ((Math.Pow((a + b * x), 2) - Math.Sin(a + z * x)));
            else if (x > b) y = (Math.Sqrt(x - (Math.Sin((b * x + z)))));
        }
        break;
}
Console.WriteLine($"y = {y:F2}");