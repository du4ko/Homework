using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneProject
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private int hdd;
        private double screen;
        private double price;
        private Battery bat;

        public Laptop(string model, double price)
        {
            this.model = model;
            this.price = price;
        }

        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, int hdd, double screen, double price, string bateryModel, double batteryLife)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Price = price;
            this.Bat = new Battery(bateryModel, batteryLife);
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Model is mandatory.");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Manufacturer must be non-empty.");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Processor must be non-empty.");
                }
                this.processor = value;
            }
        }
        public int Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("RAM must be possitive number.");
                }
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("GraphicsCard must be non-empty.");
                }
                this.graphicsCard = value;
            }
        }
        public int Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HDD must be possitive number.");
                }
                this.hdd = value;
            }
        }
        public double Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Screen inches must be possitive number.");
                }
                this.screen = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be possitive number.");
                }
                this.price = value;
            }
        }
        public Battery Bat { get; set; }

        public override string ToString()
        {
            StringBuilder laptopStringBuild = new StringBuilder();
            laptopStringBuild.AppendLine("Model: " + this.Model);
            if (this.Manufacturer == null)
            {
                laptopStringBuild.AppendLine("Price: " + this.Price);
                return laptopStringBuild.ToString();
            }
            laptopStringBuild.AppendLine("Manufacturer: " + this.Manufacturer);
            laptopStringBuild.AppendLine("Processor: " + this.Processor);
            laptopStringBuild.AppendLine("Ram: " + this.Ram);
            laptopStringBuild.AppendLine("GraphicsCard: " + this.GraphicsCard);
            laptopStringBuild.AppendLine("HDD: " + this.Hdd);
            laptopStringBuild.AppendLine("Screen: " + this.Screen);
            laptopStringBuild.AppendLine("Price: " + this.Price);
            laptopStringBuild.AppendLine("bateryModel: " + this.Bat.BateryModel);
            laptopStringBuild.AppendLine("bateryLife: " + this.Bat.BateryLife);
            return laptopStringBuild.ToString();
        }
    }
}
