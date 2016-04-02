using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{

    public enum AccountType
    {
        Savings,
        Checking,
        CD
    }
    /// <summary>
    /// This is an account class
    /// </summary>
    public class Account
    {
        #region Variables
        private static int lastAccountNumber = 0;
        #endregion


        #region Properties
        /// <summary>
        /// Account number for the a/c
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// Name of the a/c
        /// </summary>
        public String AccountName { get; set; }
        public int SSN { get; set; }
        public double Balance { get; private set; }
        public AccountType TypeofAccount { get; set; }
        #endregion

        #region Constructor
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
        }
        #endregion

        #region Methods
        public double Deposit(double amount) {
            Balance += amount;
            return Balance;
        }
        #endregion

    }
}
