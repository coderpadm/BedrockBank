using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public static class Bank
    {
       /// <summary>
       /// Create a new account
       /// </summary>
       /// <param name="accountName">Name of your account</param>
       /// <param name="ssn">Social Security Number</param>
       /// <param name="typeOfAccount">The type of account</param>
       /// <returns>A new account</returns>
        public static Account CreateAccount(string accountName, int ssn,AccountType typeOfAccount)
        {
            //Initializer
            var account = new Account
            {
                AccountName = accountName,
                SSN = ssn,
                TypeofAccount = typeOfAccount
            };
            return account;
        }
    }
}
