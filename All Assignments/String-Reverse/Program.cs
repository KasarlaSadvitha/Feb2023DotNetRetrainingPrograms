using System;

public class StringClass
{
    public static void Main(string[] args)
    {
        char temp;
        Console.WriteLine("Enter A Word\n");
        string word = Console.ReadLine();
        char[] carr = word.ToCharArray();

        for (int i = 0; i < (carr.Length) / 2; i++)
        {
            temp = carr[i];
            carr[i] = carr[carr.Length - 1 - i];
            carr[carr.Length - 1 - i] = temp;

        }

        string ReverseWord = new string(carr);
        string ReverseWord2 = string.Join("", carr);
        string ReverseWord3 = string.Concat(carr);
        //string str = string.Concat(character_array);
        //string str = string.Join("", character_array);

        Console.WriteLine("The Length of Word is   :" + ReverseWord3);

    }
}

