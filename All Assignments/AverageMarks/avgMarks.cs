using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int aspNetMarks;
        int CMarks;
        int SqlServerMarks;
        int minAvgMarks = 50;
        float Avg;
        string Result;
        bool x;
        do
        {
            Console.WriteLine("Enter Your Marks Below for each Subject ");
            Console.WriteLine(" asp.net Marks :");
            aspNetMarks = int.Parse(Console.ReadLine());
            Console.WriteLine(" C# Marks :");
            CMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Sql Server Marks :");
            SqlServerMarks = int.Parse(Console.ReadLine());
            x = ((aspNetMarks <= 100 && aspNetMarks > 0) || (CMarks <= 100 && CMarks > 0) || (SqlServerMarks <= 100 && SqlServerMarks > 0));
            if (!(x)) { Console.WriteLine("Enter Proper Marks ie; above 0,below 100"); }
        }
        while (!(x));


        Avg = (aspNetMarks + CMarks + SqlServerMarks) / 3;
        if (Avg >= minAvgMarks)
        {
            Result = "Pass";
        }
        else
        {
            Result = "Fail";
        }
        Console.WriteLine("Your Result :" + Result);


    }
}

