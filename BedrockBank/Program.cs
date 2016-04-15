using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********Welcome to Bedrock bank**********");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Deposit into an account");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Choose an option from above");

            var option=Console.ReadLine();

            switch (option)
            {

                case "1":

                    Console.Write("What is the name of the account? ");
                    var accountName=Console.ReadLine();

                    //Creating an instance of an Account
                    var account1 = Bank.CreateAccount(accountName, 12342, AccountType.Checking);
                    Console.WriteLine("Account Name: {0}, Number: {1}, Type of account: {2}, Balance: {3:c}",
                    account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance
                    );
                    break;

                case "2":
                    break;

                case "0":
                    Console.WriteLine("Good bye!");
                    return; //quitting out of Main, as it is the entry point
                    
                default:
                    break;

            }
            /*

            //Creating an instance of an Account
            var account1 = Bank.CreateAccount("My checking", 12342, AccountType.Checking);
            account1.Deposit(1000.00);
            Console.WriteLine("Account Name: {0}, Number: {1}, Type of account: {2}, Balance: {3:c}", 
                account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance
                );

            
            var account2 = Bank.CreateAccount("My savings",12342, AccountType.Savings);
            account2.Deposit(2000.00);
            Console.WriteLine("Account Name: {0}, Number: {1}, Type of account: {2}, Balance: {3:c}",
                account2.AccountName, account2.AccountNumber, account2.TypeofAccount, account2.Balance
                );
                */
        }
    }
}
