using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethodDemo
{
    public class Vehicle
    {
        public virtual void start()
        {
            Console.WriteLine("vehicle :run for pre-run checks");
        }
    }
    public class Car : Vehicle
    {
        public override void start()
        {
            base.start();
            Console.WriteLine("Car :start with key");
        }


    }
    public class ElectricCar : Car
    {

        public override void start()
        {
            base.start();
            Console.WriteLine("Car :start with button");
        }
    }
    public class ElectricalCar : Car
    {
        public sealed override void start()
        {
            base.start();
            Console.WriteLine("electrical car:start with button");
        }
    }
    //public class HybridCar : ElectricCar
    //{
    //    public override void start()
    //    {
    //        base.start();
    //        Console.WriteLine("Hybridcar : start with hybrid system");
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricCar myElectricCar = new ElectricCar();
            myElectricCar.start();
            Console.ReadLine();
        }
    }
}
