namespace Student1
{
    public class MainClass
    {
        static int count = 0;
        static byte option;
        public static void Main()
        {
            char choice = 'y';
            List<Student> sarr = new List<Student>();
            Console.WriteLine("Enter name");



            do
            {
                Console.WriteLine("Which service would you like prefer\n1. Add Student\n2. Print Marksheet of a Student \n3. Print All student Marksheets\n4. Exit");
                Console.WriteLine("Enter your choice");



                option = byte.Parse(Console.ReadLine());



                switch (option)
                {

                    case 1:
                        Console.WriteLine("Name:");

                        string name = Console.ReadLine();
                        Console.WriteLine("Marks:");
                        int marks = int.Parse(Console.ReadLine());

                        sarr.Add(new Student(name, marks));
                        count++;
                        Console.WriteLine("Details ADDED , and ID is : {0}", sarr[count - 1].Id);




                        break;

                    case 2:
                        Console.WriteLine("Enter your roll Number :");
                        int Roll = int.Parse(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {

                            if (sarr[i].Id == Roll)
                            {
                                Console.WriteLine(sarr[i].PrintMarksheet());

                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine(count - 1);
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(sarr[i].PrintMarksheet());
                        }
                        break;

                }
                Console.WriteLine("Do you want to continue (Y|N): ");
                choice = char.Parse(Console.ReadLine());
            } while (choice == 'Y' || choice == 'y');



        }
    }
}