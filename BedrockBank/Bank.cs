using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public static class Bank
    {
        #region Variables
        private static BankModel db = new BankModel();
        #endregion

        public static Customer FindCustomer(string emailAddress)
        {
            return db.Customers.Where(
                c => c.CustomerEmail == emailAddress)
                .FirstOrDefault();

        }
        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="accountName">Name of your account</param>
        /// <param name="ssn">Social Security Number</param>
        /// <param name="typeOfAccount">The type of account</param>
        /// <returns>A new account</returns>
        public static Account CreateAccount(string accountName, int ssn,AccountType typeOfAccount, Customer customer)
        {
            //Initializer
            var account = new Account
            {
                AccountName = accountName,
                SSN = ssn,
                TypeofAccount = typeOfAccount,
                Customer = customer
            };
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="name">Customer's name</param>
        /// <param name="emailAddress">Customer's email addresss</param>
        /// <returns>The newly created Customer object</returns>
        public static Customer CreateCustomer(string name, string emailAddress)
        {

            var customer = new Customer
            {
                CustomerName=name,
                CustomerEmail=emailAddress
            };

            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;
        }
        
    }
}
