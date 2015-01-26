using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.PC_Catalong
{
    class Computer
    {
        private string name;
        private double price;
        private List<Components> components;

        public Computer(string name, List<Components> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Computer's name is mandatory!");
                }
                this.name = value;
            }
        }
        public List<Components> Components
        {
            get
            {
                return this.components;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("There must be at least one component in the computer!");
                }
                this.components = value;
            }
        }
        private double calculatePrice()
        {
            foreach (var component in this.components)
            {
                this.price += component.CompPrice;
            }
            return this.price;
        }

        public override string ToString()
        {
            string output = "Computer name: " + this.Name + "\n";
            foreach (var component in components)
            {
                output += component.ToString();
            }
            double fullPrice = calculatePrice();
            output += "Total computer price: " + fullPrice + "lv\n";
            return output;
        }
    }
}
