using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email = null)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (name == " ")
                {
                    throw new ArgumentNullException("Name and age are mandatory.");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age < 0 & age > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be in range [0...100]");
                }
                else if (age == ' ')
                {
                    throw new ArgumentNullException("Name and age are mandatory");
                }
                age = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email == null)
                {
                    email = value;
                }
                if (email.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Email must cointain @!");
                }

            }
        }
        public override string ToString()
        {
            return "This is a person called " + this.name + ". He/she is " + this.age + " years old. His/her email address is " + (string.IsNullOrEmpty(this.email) ? "not set." : this.email);
        }
       
    }
}
