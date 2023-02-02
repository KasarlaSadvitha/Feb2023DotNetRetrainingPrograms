using System;

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler



class BankAccount
{
    private static int number = 101;
    private string _name;
    private int _accountNumber;
    private string _accountType;
    private int _balance;

    public int AccountNumber
    {
        get { return this._accountNumber; }
    }

    public BankAccount(string name, string accountType, int balance)
    {
        this._name = name;
        this._accountNumber = number++;
        //this. _accountNumber = accountNumber;
        this._accountType = accountType;
        this._balance = balance;
    }



    public int Balance
    {
        get
        {
            return this._balance;
        }
    }
    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("can not deposit ");
        }
        else
        {
            this._balance += amount;
            Console.WriteLine("The deposite amount is {0} and updated balance is {1}", amount, this._balance);
        }
    }
    public void Withdraw(int amount)
    {
        if (this._balance >= amount)
        {
            this._balance -= amount;
            Console.Write("Amount withdrawn {0} and remaining balance is {1} \n", amount, this._balance);
        }
    }
    public string BankAccountSummary()
    {
        return string.Format("Account Number:{0}\n Customer Name:{1}\n Account Balance{2}", this._accountNumber, this._name, this._balance);
    }
}
public class MainClass
{
    static byte counter = 0;
    static int balance;
    static string name;
    static string accountType;
    static int amount;
    //static int AccNo;


    public static void Assign()
    {
        Console.Write("Enter  Name : ");
        name = Console.ReadLine();
        // Console.Write("Enter Account Number : ");
        // int accountNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter Account Type : ");
        accountType = Console.ReadLine();
        Console.Write("Enter accountBalance : ");
        balance = int.Parse(Console.ReadLine());
    }

    //BankAccount[] ba = new BankAccount[10];

    public static void Main()
    {

        BankAccount[] ba = new BankAccount[10];
        byte option;
        char choice;
        int accNo;
        int x;


        do
        {
            Console.WriteLine("What do you want to doo?");
            Console.WriteLine("1.Create a new account\n 2. Deposite\n 3. Withdraw\n ");
            Console.WriteLine("\n Enter your choice: ");
            option = byte.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Assign();
                    ba[counter++] = new BankAccount(name, accountType, balance);
                    Console.WriteLine("Your Account is Created Successfully with AccountNo :{0}", ba[counter - 1].AccountNumber);
                    break;
                case 2:
                    Console.WriteLine("To Deposite the amount Enter Your Account Number :");
                    accNo = int.Parse(Console.ReadLine());

                    for (int i = 0; i < counter; i++)
                    {
                        if (ba[i].AccountNumber == accNo)
                        {
                            x = i;
                            Console.WriteLine("Enter Deposite Amount");
                            amount = int.Parse(Console.ReadLine());
                            ba[x].Deposit(amount);
                            break;

                        }
                    }




                    break;

                case 3:
                    Console.WriteLine("To WithDraw the amount Enter Your Account Number :");
                    accNo = int.Parse(Console.ReadLine());

                    for (int i = 0; i < counter; i++)
                    {
                        if (ba[i].AccountNumber == accNo)
                        {
                            x = i;
                            Console.WriteLine("Enter Withdraw Amount");
                            amount = int.Parse(Console.ReadLine());
                            ba[x].Withdraw(amount);
                            break;
                        }
                    }



                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            Console.WriteLine("Do you want to continue (Y|N): ");
            choice = char.Parse(Console.ReadLine());
        } while (choice == 'Y' || choice == 'y');

        //Console.WriteLine ("Hello Mono World");
    }
}
