using System;
class Solvation
{
    static void Main()
    {
        double n;
        for(n=1.0;n<10.0;n+=0.1)
        {
            Console.WriteLine("Square {0} is {1}: ",n,Math.Sqrt(n));
            Console.WriteLine("Abs {0} is {1}",n,(int)Math.Abs(n));
            Console.WriteLine("Rho {0} is {1}", n, 0.5-(Math.Abs(n)-(int)Math.Abs(n)));
        }
    }
}
