using System;

public class Temperature
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter Temperature in Fahrenheit");
        float Fahrenheit = float.Parse(Console.ReadLine());
        float Celsius = ((Fahrenheit - 32) * 5) / 9;
        Console.WriteLine("Enter Temperature in Celsius is :{0}  0C",Celsius);


    }
}

