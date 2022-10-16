// Задача 2
Console.WriteLine("введите число");
int number11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int number22 = Convert.ToInt32(Console.ReadLine());
if (number11 > number22)
{
    Console.WriteLine("Первое число больше второго");
}

else if (number11 < number22)
{
    Console.WriteLine("Второе число больше первого");
}

else
{
    Console.WriteLine("числа равны");
}
