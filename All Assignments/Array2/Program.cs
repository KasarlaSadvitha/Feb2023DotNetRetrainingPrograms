using System;

public class AscendingDecendingOrderOfArrayElements
{
    public static void Main(string[] args)

    {
        float avg = 0;
        int min = 0;
        int max = 0;
        int temp;
        int total = 0;


        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("arr[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
            total += arr[i];
            if (i == 0)
            {
                min = arr[i];
                max = arr[i];
            }
            if (arr[i] < min) { min = arr[i]; }
            if (arr[i] > max) { max = arr[i]; }
        }
        avg = total / 10.0f;
        Console.WriteLine("Total :{0}", total);
        Console.WriteLine("Average :{0}", avg);
        Console.WriteLine("Minimum :{0}", min);
        Console.WriteLine("Maximum :{0}", max);

        for (int i = 0; i < 9; i++)
        {
            for (int j = i + 1; j < 9; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine("Ascending Order Array ");
        for (int i = 0; i < 9; i++)
        {
            Console.Write(arr[i] + ",");
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = i + 1; j < 9; j++)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("\nDescending Order Array ");
        for (int i = 0; i < 9; i++)
        {
            Console.Write(arr[i] + ",");
        }

    }
}

