﻿using System;
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
            String option;

            do
            {
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Deposit into an account");
                Console.WriteLine("3. Print accounts");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Choose an option from above");

                option = Console.ReadLine();

                switch (option)
                {

                    case "1":

                        Console.Write("What is the name of the account? ");
                        var accountName = Console.ReadLine();

                        Console.Write("What is your email address? ");
                        var emailAddress = Console.ReadLine();

                        var customer = Bank.FindCustomer(emailAddress);

                        //Creating an instance of an Account
                        var account1 = Bank.CreateAccount(accountName, 12342, AccountType.Checking, customer);
                        Console.WriteLine("Account Name: {0}, Number: {1}, Type of account: {2}, Balance: {3:c}",
                        account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance
                        );
                        break;

                    case "2":
                        break;

                    case "3":
                        //PrintAccounts();
                        break;

                    case "0":
                        Console.WriteLine("Good bye!");
                        return; //quitting out of Main, as it is the entry point

                    default:
                        break;

                }
            } while (option!="0");

        }

        //static void PrintAccounts()
        //{
        //    foreach (var account in Bank.accounts)
        //    {
        //        Console.WriteLine("Id: {0}, Name: {1}",
        //            account.AccountNumber, account.AccountName);
        //    }
        //}
    }
}
