Console.WriteLine("Введите последовательность положительных чисел:");
float a = Convert.ToSingle(Console.ReadLine());

if (a < 0)
{
    Console.WriteLine("Введите положительное число!");
}

else
{
    float min = a;
    while (a != 0)
    {
        if (a < min & a > 0)
        {
            min = a;
        }
        else if (a < 0)
        {
            Console.WriteLine("Отрицательное чисто не будет учитываться +" +
                "в последовательности.");
        }

        a = Convert.ToSingle(Console.ReadLine());
    }

    Console.WriteLine($"минимальное число = {min}");
}
