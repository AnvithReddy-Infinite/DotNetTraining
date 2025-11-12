using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
    public class EmployeeDirectory
    {
        private string[] EmpNames = { "Anil", "Bhavana", "Chirag", "Divya" };
        private int[] EmpIDs = { 101, 102, 103, 104 };

        public string this[int index]
        {
            get { return EmpNames[index]; }
            set { EmpNames[index] = value; }
        }

        public string this[string Empid]
        {
            get
            {
                for (int i = 0; i < EmpIDs.Length; i++)
                {
                    if (EmpIDs[i].ToString() == Empid)
                        return EmpNames[i];
                }
                return "Employee Not Found";
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                EmployeeDirectory empDir = new EmployeeDirectory();
                Console.WriteLine(empDir[1]);
                Console.WriteLine(empDir["103"]);
                Console.ReadLine();
            }
        }
    }
}
