using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace homework11
{
    [BankAccount("Пушкин", "NASA")]
    internal class BankAccount
    {
        static private ulong number = CreateAccountNumber();
        private double balance = 0;
        private AccountTypes type = AccountTypes.Current;
        private string holder;
        private List<BankTransaction> transactions = new List<BankTransaction>();
        public ulong Number { get { return number; } }
        public double Balance { get { return balance; } }
        public AccountTypes Type { get { return type; } }
        public string Holder { get { return holder; } set { holder = value; } }
        public BankAccount()
        {
            number = CreateNewAccountNumber();
        }
        public BankTransaction this[int index]
        {
            get
            {
                return transactions[index];
            }
            set
            {
                transactions[index] = value;
            }
        }
        static private ulong CreateAccountNumber()
        {
            Random n = new Random();
            bool flag = false;
            do
            {
                flag = ulong.TryParse(Convert.ToString(n.Next(0)), out number);
            } while (!flag);
            return (number);
        }
        private ulong CreateNewAccountNumber()
        {
            number += 1;
            return (number);
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen() 
        {
            Console.WriteLine($"Номер счёта: {number}\nБаланс: {balance}\nТип счёта: {type}");
        }
        public void WithdrawMoney(double sum)
        {
            if (sum < 0)
            {
                throw new ArgumentOutOfRangeException("Нельзя снять отрицательную сумму .");
            }
            else if (sum > balance)
            {
                throw new ArgumentOutOfRangeException("У вас нет таких денег.");
            }
            else
            {
                balance -= sum;
                BankTransaction transaction = new BankTransaction(number, number, (sum)*(-1));
                transactions.Add(transaction);
            }
        }
        public void PutMoney(double sum)
        {
            if (sum < 0)
            {
                throw new ArgumentOutOfRangeException("Нельзя положить отрицательную сумму .");
            }
            else
            {
                balance += sum;
                BankTransaction transaction = new BankTransaction(number, number, sum);
                transactions.Add(transaction);
            }
        }
        public void TransferMoney(ref BankAccount account_taker, double sum)
        {
            if (sum < 0)
            {
                throw new ArgumentOutOfRangeException("Нельзя перевести отрицательную сумму .");
            }
            else if (sum > balance)
            {
                throw new ArgumentOutOfRangeException("На счету недостаточно средств, чтобы перевести данную сумму .");
            }
            else
            {
                balance -= sum;
                account_taker.balance += sum;
                BankTransaction transaction = new BankTransaction(number, account_taker.Number, sum);
                transactions.Add(transaction);
            }
        }
    }
}