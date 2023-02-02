using System;

public class stringOperation
{
    public static void Main(string[] args)
    {
        //Boolean result1 = str1.Equals(str2);
        Console.WriteLine("Enter A Word1 : \n");
        string word1 = Console.ReadLine();
        Console.WriteLine("Enter A Word2 : \n");
        string word2 = Console.ReadLine();

        bool r = word1.Equals(word2);

        if (r) { Console.WriteLine("word1 is Same as Word2"); }
        else { Console.WriteLine("word1 and word2 are different"); }

    }
}

