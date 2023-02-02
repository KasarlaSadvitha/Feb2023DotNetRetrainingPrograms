namespace Interface_Polymorphism_Assignment
{
    interface Employee
    {
        void Job();
        int Salary(int _experience, int _hrsPerDay);

    }
    class DailyWorker : Employee
    {
        public void Job()
        {
            Console.WriteLine("Daily Worker : Physical");
        }
        public int Salary(int experience, int hrsPerDay)
        {


            int salary = (hrsPerDay * (experience / 2) * 30);
            return salary;

        }
        public void Level()
        {
            Console.WriteLine("No Levels in this Job");
        }
    }


    class SoftwareEmployee : Employee
    {
        public void Job()
        {
            Console.WriteLine(" WorkType : Mental");
        }
        public int Salary(int experience, int hrsPerDay)
        {


            int salary = (hrsPerDay * (experience / 2) * 30) +10000+ (experience * 10);
            return salary;

        }
        public void Level()
        {
            Console.WriteLine("Fresher,Consultant,Professional");
        }
    }


    class MainClass
    {
        static int experience, hrsPerDay, salary;
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Experience");
            experience = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Hours Worked Per Day");
            hrsPerDay = int.Parse(Console.ReadLine());


            DailyWorker d = new DailyWorker();
            Employee e1 = d;//interface


            Console.WriteLine("Your Job  is ");
            e1.Job();


            salary = e1.Salary(experience, hrsPerDay);
            Console.WriteLine("Your Salary is {0}", salary);

            d.Level();

            Console.WriteLine("\n\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n\n");
            SoftwareEmployee s = new SoftwareEmployee();
            Employee e2 = s;
            Console.WriteLine("Your Job  is ");
            e2.Job();


            salary = e2.Salary(experience, hrsPerDay);
            Console.WriteLine("Your Salary is {0}", salary);

            s.Level();
        }
    }
}