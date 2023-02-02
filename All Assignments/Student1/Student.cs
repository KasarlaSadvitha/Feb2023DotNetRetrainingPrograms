using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExceptionLibrary;

namespace Student1
{
    public class Student
    {
        private static int id = 101;
        public readonly int Id;
        private string Name;
        private int Marks;

        public Student(string name, int marks)
        {
            try
            {
                if (marks < 0)
                {
                    throw new MarksNegativeException();
                }
                else if (marks > 100)
                {
                    throw new MarksOverException();
                }
                else
                {
                    this.Name = name;
                    this.Marks = marks;
                    this.Id = id++;
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

        }

        public string PrintMarksheet()
        {

            return String.Format("Student Id  is {0}\n Student Name {1}\n Marks is {2}", this.Id, this.Name, this.Marks);
        }
    }
}
