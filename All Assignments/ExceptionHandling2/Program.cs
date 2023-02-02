class MainClass
{
    public static void MyMs()
    {
        try
        {
            int i = 10;
            int j = 0;
            if(j==0)
            {
                throw new DivideByZeroException("Second Argument is Zero");
            }
            else 
            { int k = i / j; }
        }

        catch (DivideByZeroException d)
        {

            Console.WriteLine("Inside Divide By Zero Exception Block");
            Console.WriteLine(d.Message);

        }
        catch (DllNotFoundException d)
        {
            Console.WriteLine(d.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + "General------------------------------");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Finally$$$$$$$$$$                 in MyMs");
        }
        Console.WriteLine("-----End---- of MyMs");
    }

    static void Main()
    {   
        try
        {
            MyMs();
        }
        catch (DllNotFoundException d)
        {
            Console.WriteLine(d.Message);
        }
        catch (DivideByZeroException d)
        {
            
            Console.WriteLine("++Inside Divide By Zero Exception Block");
           
           
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + "General------------------------------");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Finally$$$$$$$$$$$$$                    in Main");
        }
        Console.WriteLine("-------Code at the End--------------------------");


    }
}
