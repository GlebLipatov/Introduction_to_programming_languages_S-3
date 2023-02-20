using System;

bool isTrue = false;

Console.WriteLine("Заданте 19\n");

Console.WriteLine(isPolyndrom(14212) + " 14212");
Console.WriteLine(isPolyndrom(12821) + " 12821");
Console.WriteLine(isPolyndrom(23432) + " 23432");

Console.WriteLine("\nЗаданте 21\n");

Console.WriteLine(Math.Round(Distance(3, 6, 8, 2, 1, -7), 2));
Console.WriteLine(Math.Round(Distance(7, -5, 0, 1, -1, 9), 2));

Console.WriteLine("\nЗаданте 23\n");

Cubing(3, 3);
Cubing(5, 3);

Console.WriteLine("\nЗаданте доп 1\n");

do
{
    Console.Write("Сумма вклада: ");
    int m;
    isTrue = int.TryParse(Console.ReadLine(), out m);
    if (isTrue)
    {
        Bank(m);
    }
    else isTrue = false;

} while (!isTrue);

Console.WriteLine("\nЗаданте доп 2\n");

isTrue = false;
do
{
    Console.Write("Введите трехзначное число: ");
    int n;
    isTrue = int.TryParse(Console.ReadLine(), out n);
    if (isTrue && n > 99 && n < 1000)
    {
        InterestingNumber(n);
    }
    else isTrue = false;

} while (!isTrue);

/*=================> Методы <=================*/

bool isPolyndrom(int n)
{
    string s = n.ToString();
    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] != s[s.Length - 1 - i]) return false;
    }
    return true;
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

int[] Cubing(int n, int exp)
{
    int[] numbers = new int[n];

    for (int i = 0; i < n; i++)
    {
        numbers[i] = Convert.ToInt32(Math.Pow(i + 1, exp));
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
    return numbers;
}

double Bank(int money)
{
    double m = Convert.ToDouble(money);

    if (m <= 0)
    {
        Console.WriteLine("Недостаточно средств на счету.");
        return 0.0;
    }
    else if (m < 100) m *= 1.05;
    else if (m >= 100 && m < 200) m *= 1.07;
    else m *= 1.1;

    Console.WriteLine("Сумма по вкладу через 1 год: " + Math.Round(m, 2));
    return m;
}

int InterestingNumber(int n)
{
    int n100 = n / 100;
    int n10 = n % 100 / 10;
    int n1 = n % 10;

    if (n100 > n1 && n100 - n1 == n10) Console.WriteLine(n + " - число интересное, средняя цифра - " + n10 + ", разница: " + n100 + " - " + n1 + " = " + n10);
    else if (n1 - n100 == n10) Console.WriteLine(n + " - число интересное, средняя цифра - " + n10 + ", разница: " + n1 + " - " + n100 + " = " + n10);
    else Console.WriteLine(n + " - " + n10);

    return n10;
}