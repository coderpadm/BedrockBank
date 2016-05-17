using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            Customer customer;

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
                        customer = VerifyCustomer();
                        try
                        {

                            Console.Write("What is the name of the account? ");
                            var accountName = Console.ReadLine();

                            //Creating an instance of an Account
                            var account1 = Bank.CreateAccount(accountName, 12342, AccountType.Checking, customer);
                            Console.WriteLine("Account Name: {0}, Number: {1}, Type of account: {2}, Balance: {3:c}",
                            account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance
                            );
                        }
                        catch (DbEntityValidationException dx)
                        {
                            Console.WriteLine("Failed - {0}", dx.Message);

                        }
                        catch(Exception)
                        {

                            throw;
                        }

                        break;

                    case "2":
                        customer = VerifyCustomer();
                        Console.WriteLine("How much do you want to deposit ?");
                        var amount = Console.ReadLine();
                        int convertedAmount;
                        if (int.TryParse(amount, out convertedAmount) == true)
                        {

                        }
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

        private static Customer VerifyCustomer()
        {
            Console.Write("What is your email address? ");
            var emailAddress = Console.ReadLine();

            var customer = Bank.FindCustomer(emailAddress);
            if (customer == null)
            {
                Console.Write("What is your name? ");
                var name = Console.ReadLine();

                customer = Bank.CreateCustomer(name, emailAddress);

            }

            return customer;
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
