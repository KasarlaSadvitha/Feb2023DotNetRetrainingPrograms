using System;

public class StringClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter A Word\n");
        string word = Console.ReadLine();
        int l = word.Length;
        Console.WriteLine("The Length of Word is  {0} :", l);

    }
}

