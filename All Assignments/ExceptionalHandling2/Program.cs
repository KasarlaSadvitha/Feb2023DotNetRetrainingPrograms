
using System;
using System.Collections;



public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {

    }

}



public class AccountNotFoundException : Exception
{
    public AccountNotFoundException(string message) : base(message)
    {

    }

}
public class NegativeAmountException : Exception
{
    public NegativeAmountException(string message) : base(message)
    {

    }
}



public class Account
{
    public static int number = 1001;
    private int _accountNumber;
    private string _customerName;
    private string _accountType;
    private int _accountBalance;

    public Account(string _customerName, string _accountType, int _accountBalance)
    {
        this._accountNumber = number++;
        this._customerName = _customerName;
        this._accountType = _accountType;
        this._accountBalance = _accountBalance;
    }

    public int AccountNumber
    {
        get
        {
            return this._accountNumber;
        }
    }
    public void deposit(int amount)
    {
        if (amount > 0)
        {
            _accountBalance += amount;
            Console.WriteLine("{0} Rupees Deposited Successfully", amount);

        }
        else
        {
            throw new NegativeAmountException("Amount cannot be negative Kindly! Enter a valid amount");

        }
    }

    public void withdraw(int amount)
    {
        if (amount < _accountBalance && amount > 0)
        {
            _accountBalance -= amount;
            Console.WriteLine("{0} Rupees withdrawn Successfully", amount);

        }
        else
        {
            throw new InsufficientBalanceException("Insufficient Balance! Enter a valid amount");

        }

    }
    public string printDetails()
    {
        return String.Format("Account Number :{0}\nCustomer Name :{1}\nAccount Type :{2}\nAccount Balance :{3}", this._accountNumber, this._customerName, this._accountType, this._accountBalance);
    }
}




class MainClass
{
    static char option;
    static int accountNumber;
    static int amount;
    static byte choice;
    static string name;
    static string type;
    static int Initialbalance;
    static int counter = 0;
    static bool valid = false;

    static Account[] account = new Account[10];

    public static bool validation(int accountNo)
    {
        foreach (Account a in account)
        {

            if (a != null)
            {
                if (a.AccountNumber == accountNo)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                throw new AccountNotFoundException("Invalid Account Number Given");
            }
        }
        throw new AccountNotFoundException("Invalid Account Number Given"); ;
    }



    // public static bool validation(int accNo){



    //     for(int i=0;i<counter;i++){
    //     if(accNo == account[i].AccountNumber){
    //         return true;
    //     }
    //     }
    //     return false;
    // }

    static void Input()
    {
        Console.WriteLine("Enter Your Name");
        name = Console.ReadLine();
        Console.WriteLine("Enter Account Type");
        type = Console.ReadLine();
        Console.WriteLine("Enter Initial Account Balance");
        Initialbalance = int.Parse(Console.ReadLine());
    }

    static void main()
    {

        Console.WriteLine("Which Service you would like to Use\n1. Create an Account\n2. Deposit\n3. Withdraw\n4. Print All Account Details\n5. Exit");
        do
        {
            Console.WriteLine("Enter your choice");
            choice = byte.Parse(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Input();
                    account[counter++] = new Account(name, type, Initialbalance);
                    Console.WriteLine("Congratulations ! Your Account has been successfully created , Your Account Number is {0}", account[counter - 1].AccountNumber);
                    break;

                case 2:
                    Console.WriteLine("Enter the Account you want to do transaction");
                    accountNumber = int.Parse(Console.ReadLine());
                    try
                    {
                        valid = validation(accountNumber);
                    }
                    catch (AccountNotFoundException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    if (valid)
                    {
                        Console.WriteLine("Enter the amount you want to deposit");
                        amount = int.Parse(Console.ReadLine());
                        account[accountNumber - 1001].deposit(amount);

                    }
                    else
                    {
                        Console.WriteLine("Kindly! Enter a valid account number");

                    }
                    break;


                case 3:
                    Console.WriteLine("Enter the Account you want to do transaction");
                    accountNumber = int.Parse(Console.ReadLine());
                    try
                    {
                        valid = validation(accountNumber);
                    }
                    catch (AccountNotFoundException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    if (valid)
                    {
                        Console.WriteLine("Enter the amount you want to withdraw");
                        amount = int.Parse(Console.ReadLine());
                        account[accountNumber - 1001].withdraw(amount);
                        // Console.WriteLine("{0} Rupees Withdrawn Successfully",amount);
                    }
                    else
                    {
                        Console.WriteLine("Kindly! Enter a valid account number");

                    }
                    break;
                case 4:
                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine(account[i].printDetails());
                        Console.WriteLine("----------------");
                    }
                    break;

                case 5:
                    Console.WriteLine("Thank you for using our Services");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Kindly enter a valid option");
                    break;

            }
            Console.WriteLine("Do you want to continue...");
            option = char.Parse(Console.ReadLine());
            //Console.Clear();
        } while (option == 'y' || option == 'Y');
    }
    public static void Main(string[] args)
    {
        main();
    }
}
