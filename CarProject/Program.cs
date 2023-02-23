using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The car needs fuel to start driving. Please enter fuel(litres): ");
            int gas = int.Parse(Console.ReadLine());

            Car myCar = new Car();
            
            myCar.Refuel(gas);
            myCar.Drive();

        }
    }

    public class Car
    {
        public void Drive()
        {
            if (Refuel == true)
                Console.WriteLine("Driving");
        }

        public bool Refuel(int amtGas)
        {
            if(amtGas > 0)
            return true;
        }
    }

}
