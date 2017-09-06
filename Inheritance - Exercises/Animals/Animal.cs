﻿using System;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{GetType().Name}" + Environment.NewLine +
                   $"{this.Name} {this.Age} {this.Gender}" + Environment.NewLine + $"{this.ProduceSound()}";
        }
    }
}
