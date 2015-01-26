using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.PC_Catalong
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Computer> computers = AddComputers();

            foreach (var computer in computers)
            {
                Console.WriteLine(computer.ToString());
            }
        }

        static List<Computer> AddComputers()
        {
            List<Computer> computers = new List<Computer>();
            string checker = null;

            do
            {
                Console.WriteLine("Enter computer name:");
                string compName = Console.ReadLine();
                List<Components> components = AddComponents();
                Computer computer = new Computer(compName, components);
                computers.Add(computer);
                Console.WriteLine("Do you want to add another computer?(Y/N)");
                checker = Console.ReadLine();

            } while (checker != "N" && checker !="n");
            return computers;
        }
        static List<Components> AddComponents()
        {
            List<Components> components = new List<Components>();
            string checker = null;
            do
            {
                Console.WriteLine("Enter component name: ");
                string compName = Console.ReadLine();
                Console.WriteLine("Enter component description (not mandatory): ");
                string compDescription = Console.ReadLine();
                Console.WriteLine("Enter component price: ");
                double compPrice = Double.Parse(Console.ReadLine());

                Components component = new Components(compName, compPrice, compDescription);
                components.Add(component);
                Console.WriteLine("\nDo you want to add another component? (Y/N)");
                checker = Console.ReadLine(); 
               
            } while (checker !="N" && checker != "n");
            return components;
        }
    }
}
