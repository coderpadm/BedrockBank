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
            //Creating an instance of an Account
            var account1 = new Account();
            account1.AccountName = "My checking";
           // account1.AccountNumber = 1234;
            account1.TypeofAccount = AccountType.Checking;
            var newBalance=account1.Deposit(1000.00);
            Console.WriteLine("Account Name: {0}, Number: {1}, Type of account: {2}, Balance: {3:c}", 
                account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance
                );

            //Creating an instance of an Account
            var account2 = new Account();
            account2.AccountName = "My Saving";
            // account1.AccountNumber = 1234;
            account2.TypeofAccount = AccountType.Savings;
            newBalance = account2.Deposit(2000.00);
            Console.WriteLine("Account Name: {0}, Number: {1}, Type of account: {2}, Balance: {3:c}",
                account2.AccountName, account2.AccountNumber, account2.TypeofAccount, account2.Balance
                );

        }
    }
}
