using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creationals.Prototype.Models
{
    internal sealed class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public List<string> Skills { get; set; }

        public Character(string name, string @class, int health, int mana, List<string> skills)
        {
            Id = Guid.CreateVersion7();
            Name = name;
            Class = @class;
            Health = health;
            Mana = mana;
            Skills = skills;
        }
        public Character Clone()
        {
            var character = (Character)this.MemberwiseClone();
            character.Id = Guid.CreateVersion7();
            character.Skills = new List<string>( Skills);
            
            return character;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id} | [{Class}] {Name} | HP: {Health}, Mana: {Mana}");
            Console.WriteLine("Skills: " + string.Join(", ", Skills));
            Console.WriteLine(  );
        }
    }
}
