using System;

public class Student

{
    private int rollNo;
    private string name;
    private int Class;
    private int Sem;
    private string branch;
    private int Total;
    int[] marks = new int[5];
    private bool x = true;

    public bool MinMarks
    { get { return this.x; } }

    public Student(int rollNo, string name, int Class, int Sem, string branch)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.Class = Class;
        this.Sem = Sem;
        this.branch = branch;

    }

    public int TakeSubjectMarks()
    {

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter Subject{0} Marks:", i);
            marks[i] = int.Parse(Console.ReadLine());
            if (marks[i] < 35) { x = false; }
            Total += marks[i];
        }
        return Total;
    }

    public string ShowStudentData()
    {
        return String.Format("rollNO:{0}\nName:{1}\nClass:{2}\nSem:{3}\nbranch:{4}\n", this.rollNo, this.name, this.Class, this.Sem, this.branch);
    }

}
public class MainClass
{
    static int Rollno;
    static string Name;
    static int Class;
    static int Sem;
    static string Branch;
    static string Result;

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Roll NO : ");
        Rollno = int.Parse(Console.ReadLine());

        Console.WriteLine(" Name:");
        Name = Console.ReadLine();

        Console.WriteLine("Class:");
        Class = int.Parse(Console.ReadLine());

        Console.WriteLine("Semister:");
        Sem = int.Parse(Console.ReadLine());

        Console.WriteLine("Branch:");
        Branch = Console.ReadLine();


        Student stu1 = new Student(Rollno, Name, Class, Sem, Branch);

        int Total = stu1.TakeSubjectMarks();
        if (!stu1.MinMarks)
        {
            Result = "Fail";
        }
        else if ((Total / 5) < 50)
        {
            Result = "Fail";
        }
        else { Result = "Pass"; }



        Console.WriteLine("Your Result : " + Result + "\n");

        Console.WriteLine("Student Details are:");
        Console.WriteLine(stu1.ShowStudentData());
    }
}


