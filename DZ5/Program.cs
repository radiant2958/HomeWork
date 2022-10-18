// Задача 10
int SecondDigit(int number)
{
    int lastnumber = number/10;
    int  secondnumber = lastnumber%10;


    return secondnumber;

}

Console.WriteLine(SecondDigit(345));
Console.WriteLine(SecondDigit(22));
