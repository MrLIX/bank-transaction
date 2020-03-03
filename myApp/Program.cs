using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Me", 1000);
            Summ(account);

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine($"Balance: {account.Balance}");
        }

        public static void Summ(BankAccount account)
        {
            List<Transaction> noteList = new List<Transaction>();
            noteList.Add(new Transaction(350, DateTime.Now, "Olma"));
            noteList.Add(new Transaction(200, DateTime.Now, "Olcha"));
            noteList.Add(new Transaction(220, DateTime.Now, "Behi"));

            foreach (Transaction item in noteList)
            {
                account.MakeWithdrawal(item.Amount, item.Date, item.Notes);
            }
        }

    }
}