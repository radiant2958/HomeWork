// задача 13
/*int ThirdDigit(int number)
{
    
    if (number>99 )
    {
        number/=10;
        int d=number%10;
        return d; 
    }
       
     
}
Console.WriteLine(ThirdDigit(345));

*/

int Fun(int number)
{
    int[] array = new int[3];

    for (int i = 0; i < array.Length; i++)
    {
      int lastValue = number % 10;
      array[i] = lastValue;
      number = number / 10;
    }
    
    
return array[0];

}

Console.WriteLine(Fun(56));