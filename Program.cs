using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
int sum = 1;
while (true)
{
    Console.WriteLine("Выберите действие: \n 1 - сложение \n 2 - вычитание \n 3 - умножение \n 4 - деление \n 5 - возведение в степень \n 6 - квадратный корень \n 7 - 1% от числа \n 8 - факториал \n 9 - выйти из программы");
    string deistviya = Console.ReadLine();
    int num = Convert.ToInt32(deistviya);
    if (num == 1)
    {
        Console.WriteLine("Введите первое число:");
        string pervoechislo = Console.ReadLine();
        float znachenie1 = Convert.ToInt32(pervoechislo);
        Console.WriteLine("Введите второе число:");
        string vtoroechislo = Console.ReadLine();
        int znachenie2 = Convert.ToInt32(vtoroechislo);
        Console.WriteLine($"Ответ:{znachenie1 + znachenie2}");
    }
    if (num == 2)
    {
        Console.WriteLine("Введите первое число:");
        string pervoechislo = Console.ReadLine();
        float znachenie1 = Convert.ToInt32(pervoechislo);
        Console.WriteLine("Введите второе число:");
        string vtoroechislo = Console.ReadLine();
        int znachenie2 = Convert.ToInt32(vtoroechislo);
        Console.WriteLine($"Ответ:{znachenie1 - znachenie2}");
    }
    if (num == 3)
    {
        Console.WriteLine("Введите первое число:");
        string pervoechislo = Console.ReadLine();
        float znachenie1 = Convert.ToInt32(pervoechislo);
        Console.WriteLine("Введите второе число:");
        string vtoroechislo = Console.ReadLine();
        int znachenie2 = Convert.ToInt32(vtoroechislo);
        Console.WriteLine($"Ответ:{znachenie1 * znachenie2}");
    }
    if (num == 4)
    {
        Console.WriteLine("Введите первое число:");
        string pervoechislo = Console.ReadLine();
        float znachenie1 = Convert.ToInt32(pervoechislo);
        Console.WriteLine("Введите второе число:");
        string vtoroechislo = Console.ReadLine();
        int znachenie2 = Convert.ToInt32(vtoroechislo);
        if (znachenie2 == 0)
        {
            Console.WriteLine("Ошибка. Деление на ноль");
        }
        else
        {
            Console.WriteLine($"Ответ:{znachenie1 / znachenie2}");

        }
    }
    if (num == 5)
    {
        Console.WriteLine("Введите первое число:");
        string pervoechislo = Console.ReadLine();
        float znachenie1 = Convert.ToInt32(pervoechislo);
        Console.WriteLine("Введите второе число:");
        string vtoroechislo = Console.ReadLine();
        int znachenie2 = Convert.ToInt32(vtoroechislo);
        Console.WriteLine($"Ответ:{Math.Pow(znachenie1, znachenie2)}");
    }
    if (num == 6) 
    {
        Console.WriteLine("Введите первое число:");
        string pervoechislo = Console.ReadLine();
        float znachenie1 = Convert.ToInt32(pervoechislo);
        Console.WriteLine($"Ответ:{Math.Sqrt(znachenie1)}");
    }
    if (num == 7) 
    {
         Console.WriteLine("Введите первое число:");
         string pervoechislo = Console.ReadLine();
         float znachenie1 = Convert.ToInt32(pervoechislo);
        Console.WriteLine($"Ответ:{znachenie1 / 100}");
    
    }
    if (num == 8)
    {
        Console.WriteLine("Введите первое число:");
        string pervoechislo = Console.ReadLine();
        float znachenie1 = Convert.ToInt32(pervoechislo);
        for (int i = 2; i <= znachenie1; i++)
        {
            sum *= i;
            if (i == znachenie1)
            {
                Console.WriteLine($"Ответ:{sum}");
            }
        }
    }
    if (num == 9) 
    {
        return;
    }
}