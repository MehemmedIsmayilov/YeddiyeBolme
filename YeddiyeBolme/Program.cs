// See https://aka.ms/new-console-template for more information






int num = Convert.ToInt32(Console.ReadLine());
int cavab;
cavab = num / 7;
int tamEded = num / 7 * 7;
int tamEded2 = tamEded + 7; ;


if (num % 7==0)
{
    
    Console.Write("bolunur: ");
    Console.WriteLine(cavab);
    
}
else if (num % 7!=0)
    {
      if (num<tamEded+4)
    {
        Console.WriteLine(tamEded);
    }
    else
    {
    Console.WriteLine(tamEded2);

    }
    }