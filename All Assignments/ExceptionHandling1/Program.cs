class MainClass
{ 
    static void MyMs()
    {
        try
        {
            Console.WriteLine("Enter Your First Number");
            int i=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Second Number");
            int j = int.Parse(Console.ReadLine());

            Console.WriteLine(i/j);

        }
        
       
       
        catch (Exception e)
        {
            Console.WriteLine(e.Message + "1111General------------------------------");
        }
        finally
        {
            Console.WriteLine("Finally$$$$$$$$$$                         Closing MyMs");
        }
        Console.WriteLine("After Finally.......             in MyMs");
    }

    static void Main()
    {   Repeat:
        try
        {
            MyMs();
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Second Argument Is Zero");
            Console.WriteLine(e.StackTrace);
            goto Repeat;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + "22222General------------------------------");
        }
        finally
        {
            Console.WriteLine("Finally$$$$$$$$$$$$$                    in Main");
        }
        Console.WriteLine("-------Code at the End--------------------------");
    }






}
