namespace SalaryIncrease
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.salary = salary;
        }

        public double Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public void IncreaseSalary(double percent)
        {
            if (this.Age > 30)
            {
                this.salary += (this.salary * percent) / 100;
            }
            else
            {
                this.salary += (this.salary * percent) / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} get {this.salary:F2} leva";
        }
    }
}

