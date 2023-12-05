using System;

namespace LAB
{
    internal class BankTransaction
    {
        public readonly DateTime transactionDate;
        public readonly double money;

        public BankTransaction(double money)
        {
            transactionDate = DateTime.Now;
            this.money = money;
        }
        public string Print()
        {
            return ($"Время операции: {transactionDate}\nСумма операции: {money} рублей");
        }
    }
}