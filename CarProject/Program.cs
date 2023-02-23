using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    //https://www.exercisescsharp.com/oop/interfaces
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The car needs fuel to start driving. Please enter fuel(litres): ");
            int gas = int.Parse(Console.ReadLine());

            Car myCar = new Car();
            
            myCar.Refuel(gas);
            myCar.Drive();

            Console.ReadLine();
        }
    }

    public class Car
    {
        public int carGas { get; set; }
        public void Drive()
        {
            if (carGas > 0)
                Console.WriteLine("\nDriving");
            else
                Console.WriteLine("\nNot Driving");
        }

        public bool Refuel(int amtGas)
        {
            carGas = amtGas;            
            if(carGas > 0)
                return true;
            else
                return false;
        }
    }

}
