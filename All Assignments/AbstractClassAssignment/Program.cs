using System;
public abstract class Student
{
    private string name;
    private int Class;

    public abstract int getPercentage();
    // public static int getTotalNoStudents()
    // {

    // }

    public Student(string name, int Class)
    {
        this.name = name;
        this.Class = Class;
    }
}
public class ScienceStudent : Student
{
    private int PhysicsMarks;
    private int ChemistryMarks;
    private int MathsMarks;
    public static int NoOfStudents = 0;

    public ScienceStudent(string name, int Class, int phy, int che, int mat) : base(name, Class)
    {
        this.PhysicsMarks = phy;
        this.ChemistryMarks = che;
        this.MathsMarks = mat;
    }

    public override int getPercentage()
    {


        Console.WriteLine("------------------");
        int t = this.PhysicsMarks + this.ChemistryMarks + this.MathsMarks;

        return t / 3;

    }
}



public class HistoryStudent : Student
{
    private int HistoryMarks;
    private int CivicsMarks;

    public static int NoOfStudents;

    public HistoryStudent(string name, int Class, int his, int civ) : base(name, Class)
    {
        this.HistoryMarks = his;
        this.CivicsMarks = civ;

    }

    public override int getPercentage()
    {
        int total = this.HistoryMarks + this.CivicsMarks;
        return total / 2;
    }
}

public class MainClass
{
    public static void Main()
    {

        Student[] s = new Student[10];
        char choice = 'y';
        int count = 0;
        int Class;
        string name;
        int science, chemistry, maths, history, civics;

        do
        {

            Console.WriteLine("1. Science Student\n2.History\n3.Exit\n\n");
            Console.WriteLine("Enter a no. from Above options: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Science  Student --, please enter the following : ");
                    Console.WriteLine("Enter Your Name");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter Class");
                    Class = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Science Marks ");
                    science = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Chemistry");
                    chemistry = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Maths");
                    maths = int.Parse(Console.ReadLine());

                    s[count++] = new ScienceStudent(name, Class, science, chemistry, maths);

                    Console.WriteLine("Your Percentage is : {0}", s[count - 1].getPercentage());
                    break;

                case 2:
                    Console.WriteLine("History  Student --, please enter the following : ");
                    Console.WriteLine("Enter Your Name");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter Class");
                    Class = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter History Marks ");
                    history = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter civics Marks");
                    civics = int.Parse(Console.ReadLine());



                    s[count++] = new HistoryStudent(name, Class, history, civics);

                    Console.WriteLine("Your Percentage is : {0}", s[count - 1].getPercentage());


                    break;

                case 3:
                    Console.WriteLine("Thank you!!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please Enter Correct option from above description of Tasks");
                    break;
            }


            Console.WriteLine("\n Do U Want To Continue :");
            choice = char.Parse(Console.ReadLine());
        } while (choice == 'Y' || choice == 'y');

    }
}

