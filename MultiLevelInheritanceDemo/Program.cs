using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            Professor professor1 = new Professor() { Name = "Anvith", Course = "Social" };
            professor.Name = "Anvith";
            professor.ShowName();
            professor.Course = "Computer Network";
            professor.ShowCourse();
            professor.ConductResearch();
            Console.ReadLine();
        }
    }
}
