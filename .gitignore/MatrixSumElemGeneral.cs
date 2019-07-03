using System;
class diag
{
    static void Main()
    {
            int [,] m=new int[3,3] {{1,2,3},{3,2,1},{12,13,41}};
            int sum=1;
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if(i==j)
                    {
                        sum+=m[i,j];
                    }      
                }
            }
            Console.WriteLine(sum);
    }
}
