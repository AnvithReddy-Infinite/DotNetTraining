using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceDemo
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person Constructor called");
        }
        public string Name;
        public void ShowName() => Console.WriteLine($"Name: {Name}");
    }
    class Teacher : Person
    {
        public Teacher()
        {
            Console.WriteLine("Teacher Constructor");
        }
        public string Course;
        public void ShowCourse() => Console.WriteLine($"{Name} teaches {Course}");
    }
    class Professor : Teacher
    {
        public Professor()
        {
            Console.WriteLine("Professor Constructor");
        }
        public void ConductResearch() => Console.WriteLine($"{Name} is conducting R&D in {Course}");
    }
}
internal class Person
    {
    }

