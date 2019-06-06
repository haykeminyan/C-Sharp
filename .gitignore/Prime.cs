using System;
class CheckNum
{
    public bool IsPrime(int x)
    {
        if(x<=1)
            return false;
        for(int i=2;i<=x/i;i++)
        {
            if(x%i==0)
                return false;
        }
        return true;
    }
}
class Demo
{
    static void Main()
    {
        CheckNum ob=new CheckNum();
        for(int i=2;i<20;i++)
        {
            if(ob.IsPrime(i))
            {
                Console.WriteLine(i+" is a prime number");
            }
            else
            {
                Console.WriteLine(i+" isn`t a prime number");
            }
        }
    }
}
