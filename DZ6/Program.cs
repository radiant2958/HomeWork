// задача 13

int GetLengtArray(int number)
{
    int count = 0;
    while(number>0)
    {
        number/= 10;
        count++;
    }
    return count;
}


int ThirdDigit(int number)
{
    int lengt = GetLengtArray(number);
    int[] array = new int[lengt];

        for (int i = 0; i < array.Length; i++)
        {
        int lastValue = number % 10;
        array[i] = lastValue;
        number = number / 10;
        }
      Array.Reverse(array);
      return array[2] ;
    
}

Console.WriteLine(ThirdDigit(35));

