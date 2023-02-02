using System;
class InSufficientBalance : Exception
{

    // Constructor
    public InSufficientBalance()
    {
        Console.Write("Exception has occurred : ");
    }
}
public class BankingSystem
{
    static void Main()
    {

        int _accountNumber;
        int _balance;
        Console.WriteLine("Enter Balance");
        _balance = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Account No");
        _accountNumber = int.Parse(Console.ReadLine());

        string Deposite(int amount)
        {

            _balance += amount;
            return String.Format("Your amount is Deposited Successfully , Your Current Account Balance is {0}", _balance);
        }

        string WithDraw(int amount)
        {
            if (_balance < 500)
            {
                throw new InSufficientBalance();
            }
            _balance -= amount;
            return String.Format("Your amount is WithDrawn Successfully , Your Current Remaining Account Balance is {0}", _balance);
        }









        char transactionChoice = 'y';







        try
        {

            do
            {




                Console.WriteLine("Enter no. What You Want To Do \n 1.Deposite \n 2. WithDraw \n 3. Balance");
                int transaction = int.Parse(Console.ReadLine());
                switch (transaction)
                {
                    case 1:
                        Console.WriteLine("Enter Deposite Amount");
                        int DepositeAmount = int.Parse(Console.ReadLine());
                        Console.WriteLine(Deposite(DepositeAmount));
                        break;
                    case 2:
                        Console.WriteLine("Enter WithDraw  Amount");
                        int WithDrawAmount = int.Parse(Console.ReadLine());
                        Console.WriteLine(WithDraw(WithDrawAmount));
                        break;


                }



                Console.WriteLine("Do u want to Continue Transaction ");
                transactionChoice = char.Parse(Console.ReadLine());
            } while (transactionChoice == 'Y' || transactionChoice == 'y');

        }

        catch (Exception e)
        {
            // Message property of exception object e
            // will give the specific type of the exception
            Console.Write(e.Message);
        }


    }
}


