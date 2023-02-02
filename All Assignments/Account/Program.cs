using System;

public class Accounts
{
    private int AccountNo;
    private string Customer_Name;
    private string Account_Type;
    // private char Transaction;
    private int balance;
    //private int amount;

    public Accounts(int accNo, string custName, string accType, int initial_balance)
    {
        this.AccountNo = accNo;
        this.Customer_Name = custName;
        this.Account_Type = accType;
        this.balance = initial_balance;

    }

    public void Credit(int amount)
    {
        balance += amount;
        Console.WriteLine("your Total Balance is : {0}", this.balance);

    }
    public void Debit(int amount)
    {
        balance -= amount;
        Console.WriteLine("");
        Console.WriteLine("your Total Balance is : {0}", this.balance);
    }

    public string ShowData()
    {
        return String.Format("AccountNo:{0}\nCustomer_Name:{1}\nAccount_Type:{2}\nbalance:{3}", this.AccountNo, this.Customer_Name, this.Account_Type, this.balance);
    }

}
public class MainClass
{
    static int accNo;
    static string custName;
    static string accType;
    static int initialBalance;
    static int amount;


    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Account No : ");
        accNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Customer Name:");
        custName = Console.ReadLine();

        Console.WriteLine("Account Type");
        accType = Console.ReadLine();

        Console.WriteLine("Initial Balance");
        initialBalance = int.Parse(Console.ReadLine());

        Accounts acc1 = new Accounts(accNo, custName, accType, initialBalance);

        Console.WriteLine("D =Deposite\nW=Withdrew\nEnter Your Transaction Type:");
        char x = char.Parse(Console.ReadLine());

        switch (x)
        {
            case 'D':

                Console.WriteLine("Amount to be Deposited : ");
                amount = int.Parse(Console.ReadLine());
                acc1.Credit(amount);

                break;
            case 'W':
                Console.WriteLine("Amount to be Withdrawn : ");
                amount = int.Parse(Console.ReadLine());
                acc1.Debit(amount);
                break;
            default:
                Console.WriteLine("Invalid Transaction Type");
                break;
        }

        Console.WriteLine("\n Your Account Details are : ");
        Console.WriteLine(acc1.ShowData());

    }
}

