using System;

public class HelloWorld
{
    public static void Main(string[] args)

    {
        int avg = 0;
        int min = 0;
        int max = 0;
        Console.WriteLine("Enter the size of the Array");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("arr[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
            avg += arr[i];
            if (i == 0)
            {
                min = arr[i];
                max = arr[i];
            }
            if (arr[i] < min) { min = arr[i]; }
            if (arr[i] > max) { max = arr[i]; }
        }
        avg = avg / size;
        Console.WriteLine("Average :{0}", avg);
        Console.WriteLine("Minimum :{0}", min);
        Console.WriteLine("Maximum :{0}", max);


    }
}


