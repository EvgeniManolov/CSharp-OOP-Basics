using System;
using System.Collections.Generic;

namespace DefineBankAccountClass
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArgs = command.Split();
                string cmdType = cmdArgs[0];

                switch (cmdType)
                {
                    case "Create":
                        Create(cmdArgs, accounts);
                        break;
                    case "Deposit":
                        Deposit(cmdArgs, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(cmdArgs, accounts);
                        break;
                    case "Print":
                        Print(cmdArgs, accounts);
                        break;
                }
                command = Console.ReadLine();
            }
        }

        private static void Print(string[] cmdArgs, Dictionary<string, BankAccount> accounts)
        {
            string id = cmdArgs[1];
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id].ToString());
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] cmdArgs, Dictionary<string, BankAccount> accounts)
        {
            string id = cmdArgs[1];
            int amount = int.Parse(cmdArgs[2]);

            if (accounts.ContainsKey(id))
            {
                if (accounts[id].Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(string[] cmdArgs, Dictionary<string, BankAccount> accounts)
        {
            string id = cmdArgs[1];
            int amount = int.Parse(cmdArgs[2]);

            if (accounts.ContainsKey(id))
            {
                accounts[id].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(string[] cmdArgs, Dictionary<string, BankAccount> accounts)
        {
            string id = cmdArgs[1];

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }
        }
    }
}