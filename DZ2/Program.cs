// Задача 4
Console.WriteLine("введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1>number2 & number1> number3)
{
    Console.WriteLine(number1);
}

else if (number2>number1 & number2>number3)
{
    Console.WriteLine(number2);
}

else
{
    Console.WriteLine(number3);
}
