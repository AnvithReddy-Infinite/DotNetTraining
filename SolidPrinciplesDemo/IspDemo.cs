using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    //ISP: Interface Segregation Principle
    interface IManageable
    {
        void ManageTeam();
    }

    public class Worker : IWorkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Worker is eating.");
        }
    }

    public class Manager : IWorkable, IEatable, IManageable
    {
        public void Work()
        {
            Console.WriteLine("Manager is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Manager is eating.");
        }

        public void ManageTeam()
        {
            Console.WriteLine("Manager is managing the team.");
        }
    }

    public class RobotWorker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working nonstop.");
        }
    }

    class IspDemo
    {
        static void Main(string[] args)
        {
            IWorkable worker = new Worker();
            IWorkable managerAsWorker = new Manager();
            IWorkable robot = new RobotWorker();

            IEatable eatingWorker = new Worker();
            IEatable eatingManager = new Manager();

            IManageable teamManager = new Manager();

            worker.Work();
            managerAsWorker.Work();
            robot.Work();

            eatingWorker.Eat();
            eatingManager.Eat();

            teamManager.ManageTeam();

            Console.WriteLine("ISP example finished. Press any key to exit.");
            Console.ReadKey();
        }
    }

    internal interface IEatable
    {
        void Eat();
    }

    internal interface IWorkable
    {
        void Work();
    }
}
