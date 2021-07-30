using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvial 
{
    class Survivor : ITargetable
    {
        public List<string> Equipment { get; set; } = new List<string>();
        public int Reputation { get; private set; } = 100;
        public bool IsZombie { get; } =  false;


        public Survivor(string startingEquipment)
        {
            Equipment.Add(startingEquipment);
        }

        public void PickUpEquip(string newEquipment)
        {
            Equipment.Add(newEquipment);
        }


       
        public void Attack(ITargetable attackee)
        {
            if(!attackee.IsZombie)
            {
                Reputation = Reputation - 10;
            }
            
        }
    }
}
