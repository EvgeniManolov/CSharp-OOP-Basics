﻿using System.Collections.Generic;
using System.Linq;

namespace DefineBankAccountClass
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.accounts = new List<BankAccount>();
        }

        public Person(string name, int age, List<BankAccount> accounts)
            : this(name, age)
        {
            this.accounts = accounts;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public double GetBalance()
        {
            return this.accounts.Select(a => a.Balance).Sum();
        }
    }
}

