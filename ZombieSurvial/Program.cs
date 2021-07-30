using System;

namespace ZombieSurvial
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Survivor("gun");
            var jack = new Survivor("bat");
            var zombie = new Zombie();
        
            john.PickUpEquip("knife");
            foreach (string equ in john.Equipment)
            {
                Console.WriteLine(equ);
            }
            john.Attack(zombie);
            Console.WriteLine(john.Reputation);
        }
    }
}
