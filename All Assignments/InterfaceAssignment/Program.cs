using System;

interface interfaceOne
{
    void methodOne();
}
interface interfaceTwo
{
    void methodTwo();
}
interface interfaceThree : interfaceOne, interfaceTwo
{
    void methodThree();
}
interface interfaceFour
{
    void methodFour();
}

public abstract class ClassOne : interfaceThree
{
    public void methodOne()
    {
        Console.WriteLine("Class1-Interface1 -Method1");
    }

    public void methodTwo()
    {
        Console.WriteLine("Class1-Interface2 -Method2");
    }


    public virtual void methodThree()
    {
        Console.WriteLine("Class2-Interface3 -Method3");
    }


}

public class ClassTwo : ClassOne, interfaceFour
{
    public void methodFour()
    {
        Console.WriteLine("Class2-Interface4 -Method4");
    }

    public override void methodThree()
    {
        Console.WriteLine("Class2-Interface3 -Method3");
    }
}

public class MainClass
{
    public static void Main()
    {
        ClassTwo c2 = new ClassTwo();
        c2.methodOne();
        c2.methodTwo();
        c2.methodThree();
        c2.methodFour();

        Console.WriteLine("-----------------");

        ClassOne c1 = new ClassTwo();
        c1.methodOne();
        c1.methodTwo();
    }
}


