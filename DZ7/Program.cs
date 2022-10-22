// Задача 15

 bool Weekday(int number, bool a)
 {
    Console.WriteLine("сегодня выходной?");
    if (number ==6 | number==7)
    {
        a=true; 
        Console.WriteLine("да");
        
    }
    else
    {
        a=false;
        Console.WriteLine("нет");
      
    }
    return a;
 
 }


Weekday(3, true);
