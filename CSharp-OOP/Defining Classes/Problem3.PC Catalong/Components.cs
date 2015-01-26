using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.PC_Catalong
{
    class Components
    {
        private string compName;
        private double compPrice;
        private string compDescription;

        public Components(string compName, double compPrice, string compDescription = null)
        {
            this.CompName = compName;
            this.CompPrice = compPrice;
            this.CompDescription = compDescription;
        }

        public string CompName
        {
            get
            {
                return this.compName;
            }
            set
            {
                if(value == string.Empty)
                {
                    throw new ArgumentNullException("Component name is mandatory!");
                }
                this.compName = value;
            }
        }
        public double CompPrice 
        {
            get 
            {
                return this.compPrice;
            }
            set
            {
                if (value <= 0 || Double.IsNaN(value))
                {
                    throw new ArgumentOutOfRangeException("Component Price is mandatory positive number");
                }
                this.compPrice = value;
            }
        }
        public string CompDescription {
            get { return this.compDescription; }
            set{ this.compDescription = value;}
        }
        public override string ToString()
        {
            string output = "Component name: " + this.CompName + "\n";
            if (string.Empty != this.CompDescription)
            {
                output += "Component description: " + this.CompDescription + "\n";
            }
            else
            {
                output += "Component description: no description added" + "\n";
            }
            output += "Component price: " + this.CompPrice + "lv\n\n";
            return output;
        }
    }
}
