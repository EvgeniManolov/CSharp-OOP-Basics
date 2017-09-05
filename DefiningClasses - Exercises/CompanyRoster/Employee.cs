﻿namespace CompanyRoster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = "n/a";
            this.Age = -1;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public decimal Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }

        public string Position
        {
            get { return this.position; }
            private set { this.position = value; }
        }

        public string Department
        {
            get { return this.department; }
            private set { this.department = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
