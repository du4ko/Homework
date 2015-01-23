using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneProject
{
    class Battery
    {
        private string bateryModel;
        private double bateryLife;

        public Battery(string bateryModel, double bateryLife)
        {
            this.BateryLife = bateryLife;
            this.BateryModel = bateryModel;
        }

        public string BateryModel
        {
            get
            {
                return this.bateryModel;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Battery Model cannot is mandatory!");
                }
                this.bateryModel = value;
            }

        }
        public double BateryLife
        {
            get
            {
                return this.bateryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery life cannot be negative value!");
                }
                this.bateryLife = value;
            }

        }
    }
}
