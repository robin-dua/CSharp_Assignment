using System;
public class Table
{
    public static void Main()
    {
        int i, n;
        Console.Write("Multiplication Table of 2 to 4:\n");

        Console.Write("Enter the number: ");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= 4; i++)
        {
            Console.Write("{0} X {1} = {2} \n", n, i, n * i);
        }
    }
}
