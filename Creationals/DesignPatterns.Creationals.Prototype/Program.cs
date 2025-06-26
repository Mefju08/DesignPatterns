using DesignPatterns.Creationals.Prototype.Models;

namespace DesignPatterns.Creationals.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var character = new Character("Edd", "Warrior", 100,
                200, new List<string>()
                {
                   "attack"
                });
            character.Display();

            var characterCopy = character.Clone();
            characterCopy.Display();
        }
    }
}
