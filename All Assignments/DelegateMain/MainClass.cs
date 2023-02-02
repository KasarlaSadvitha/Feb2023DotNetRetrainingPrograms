
//using DelegateLibrary ;
using PrinterLibrary;
using StudentLibrary;

class MainClass
{
    static string name;
    static int cclass;
    static int marks;
    public static void EnterUrDetails()
    {
        Console.WriteLine("Enter Name :");
        name = Console.ReadLine();
        Console.WriteLine("Enter Class :");
        cclass = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks :");
        marks = int.Parse(Console.ReadLine());

    }
    public static void Main()
    {
        EnterUrDetails();
        Student s1 = new Student(name, cclass, marks);
       // PrintDelegate dd = new PrintDelegate(s1.DisplayStudent());
       // Printer.Print(dd);
    }
}


