using System;
class Calc
{
    static void Main()
    {
        Console.WriteLine("Число\tКвадрат\tКуб\tЧетвертая");
        for(int i=1;i<16;i++)
            Console.WriteLine("{0}\t{1}\t{2}\t{3}",i,Math.Pow(i,2),Math.Pow(i,3),Math.Pow(i,4));
    }
}
