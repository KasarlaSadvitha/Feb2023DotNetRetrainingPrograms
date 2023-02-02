using PrinterLibrary;
namespace StudintLibrary

{
    public class Student
    {
        public static int id = 101;
        public readonly int Id;
        public string Name;
        public int Class;
        public int Marks;

        public Student(string name, int cclass, int marks)
        {
            this.Name = name;
            this.Class = cclass;
            this.Marks = marks;
            this.Id = id++;
        }

        private void DisplayStudent()
        {
            Console.WriteLine("Id :{0}\n Name :{1}\nClass:{2}\nMarks :{3}", this.Id, this.Name, this.Class, this.Marks);
        }

        //public void

        PrintDelegate dd = new PrintDelegate(DisplayStudent);

    }
}