using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCharacter warrior = new GameCharacter
            {
                Health = 150,
                Attack = 40,
                Defense = 25,
                Skills = new List<string> { "Slash", "Block" }
            };

            GameCharacter unit1 = warrior.Clone();
            unit1.Skills.Add("Charge");

            GameCharacter unit2 = warrior.Clone();

            Console.WriteLine("Warrior Prototype: " + warrior);
            Console.WriteLine("Unit1: " + unit1);
            Console.WriteLine("Unit2: " + unit2);
        }

    }
}

