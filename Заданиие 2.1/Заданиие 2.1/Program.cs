Console.Write("Введите число: ");
int p = Convert.ToInt32(Console.ReadLine());
float sum = 0;
int n = 0;

for (int i = 1; ; i++)
{
    Console.Write("Введите число: ");
    float c = Convert.ToSingle(Console.ReadLine());

    if (c > 0 & c % 2 == 1 & c % 1 == 0)
    {
        sum += c;
        n++;
    }

    if (n == p)
    {
        break;
    }
}

Console.WriteLine($"\n Сумма первых {n} положительных " +
    $"+ нечётных чисел = {sum}");

var people = new List<string>() {"Person_0", "Person_1", "Person_2"};
Console.WriteLine(people[0]);
