using System;

public class LargestSmallestOf3Nos
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter A Number n1 :");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter A Number n2 :");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter A Number n3 :");
        int n3 = Convert.ToInt32(Console.ReadLine());

        int largestNo;
        int smallestNo;
        if (n1 > n2 && n1 > n3)
        {
            largestNo = n1;
            if (n2 < n3) { smallestNo = n2; }
            else { smallestNo = n3; }

        }
        else if (n2 > n3)
        {
            largestNo = n2;
            if (n1 < n3) { smallestNo = n1; }
            else { smallestNo = n3; }
        }
        else
        {
            largestNo = n3;
            if (n1 < n2) { smallestNo = n1; }
            else { smallestNo = n2; }
        }

        Console.WriteLine("_________________________________");
        Console.WriteLine("The Largest No is {0}", largestNo);
        Console.WriteLine("The Smallest No is {0}", smallestNo);

    }
}

