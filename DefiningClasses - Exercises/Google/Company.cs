using System;

namespace Google
{
    public class Company
    {
        private string name;
        private string department;
        private decimal salary;

        public Company(string name, string department, decimal salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Department
        {
            get { return this.department; }
            private set { this.department = value; }
        }

        public decimal Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2:F2}", this.Name, this.Department, this.Salary);
        }
    }
}
