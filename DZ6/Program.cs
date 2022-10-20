// задача 13
int ThirdDigit(int number)
{
    int[] array = new int[3];

        for (int i = 0; i < array.Length; i++)
        {
        int lastValue = number % 10;
        array[i] = lastValue;
        number = number / 10;
        }
      
      array=Array.Reverse(array);
      
      
      return array[2];
    
}

Console.WriteLine(ThirdDigit(678));