using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //fields

        //props
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //ctors
        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        //methods
        public override string ToString()
        {
            return string.Format("Customer #{0} Account Details:\n\n{1}\n\nBalance: {2:c}\nPast Due? {3}\nAnnual Interest Rate: {4}%", AccountNumber, CustomerInfo, Balance, IsPastDue == true ? "Yes" : "No", AnnualInterestRate);
        }
    }
}
