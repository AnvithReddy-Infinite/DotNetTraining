using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GameCharacter
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public List<string> Skills { get; set; } = new List<string>();

        public GameCharacter Clone()
        {
            return new GameCharacter
            {
                Health = this.Health,
                Attack = this.Attack,
                Defense = this.Defense,
                Skills = new List<string>(this.Skills)
            };
        }

        public override string ToString()
        {
            return $"Health: {Health}, Attack: {Attack}, Defense: {Defense}, Skills: {string.Join(",", Skills)}";
        }

    }
}
