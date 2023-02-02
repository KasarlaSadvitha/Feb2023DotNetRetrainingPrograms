using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter A Number :");
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {

            Console.WriteLine("Enter A Proper Number Other than 0");
        }
        else if (n % 2 == 0)
        {
            Console.WriteLine("Number is even");

        }
        else
        {
            Console.WriteLine("Number is odd");
        }



    }
}


