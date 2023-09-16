// See https://aka.ms/new-console-template for more information
int d;
int c;
int a;
int b;
double K;

do
{
    Console.WriteLine("Список действий:");
    Console.WriteLine("1. сложение");
    Console.WriteLine("2. вычитание");
    Console.WriteLine("3. умножение");
    Console.WriteLine("4. деление");
    Console.WriteLine("5. возведение в степень");
    Console.WriteLine("6. найти квадратный корень");
    Console.WriteLine("7. 1% от числа");
    Console.WriteLine("8. нахождение факториала");
    Console.WriteLine("9 и более. выход из программы");
    Console.WriteLine("введите действие:");
     c = Convert.ToInt32(Console.ReadLine());
    if (c==1)
    {
        Console.WriteLine("введите первое число:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = Convert.ToInt32(Console.ReadLine());
        d = a + b;
        Console.WriteLine("Результат" + d);
    }
    if (c == 2)
    {
        Console.WriteLine("введите первое число:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = Convert.ToInt32(Console.ReadLine());
        d = a - b;
        Console.WriteLine("Результат" + d);
    }
    if (c == 3)
    {
        Console.WriteLine("введите первое число:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = Convert.ToInt32(Console.ReadLine());
        d = a * b;
        Console.WriteLine("Результат" + d);
    }
    if (c == 4)
    {
    Console.WriteLine("введите первое число:");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    b = Convert.ToInt32(Console.ReadLine());
    d = a / b;
    Console.WriteLine("Результат" + d);
    }
    if (c == 5)
    {
    Console.WriteLine("Введите число:");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень:");
    b = Convert.ToInt32(Console.ReadLine());
    d = (int) Math.Pow(a, b);
    Console.WriteLine("Результат:" + d);
    }
    if (c == 6)
    {
    Console.WriteLine("Введите число:");
    a = Convert.ToInt32(Console.ReadLine());
    d = (int)Math.Sqrt(a);
    Console.WriteLine("Результат:" + d);
    }
    if (c == 7)
    {
    Console.WriteLine("Введите число:");
    a = Convert.ToInt32(Console.ReadLine());
    K = Convert.ToDouble(a);
    K = (K * 0.01);
    Console.WriteLine("Результат:" + K);

    }
    if (c == 8)
    {
        Console.WriteLine("Введите число");
        a = Convert.ToInt32(Console.ReadLine());
        b = 1;
        for (int i=1;i<=a; i++)
        {
            b = b * i;
        }
        Console.WriteLine("Результат "+b);

    }
}
while (c < 9);