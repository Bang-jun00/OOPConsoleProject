using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject
{
    public enum ClassType
    {
        None = 0,
        Warrior = 1,
        Mage = 2
    }





    public class CreatCharacter
    {
        
        public string Nickname { get; set; }
        public ClassType CharacterClass { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Intelligent {  get; set; }


        public CreatCharacter(string nickname, ClassType characterClass)
        {
            Nickname = nickname;
            CharacterClass = characterClass;
            Setstats();
        }


        private void Setstats()
        {
            switch(CharacterClass)
            {
                case ClassType.Warrior:
                    Health = 150;
                    AttackPower = 30;
                    Intelligent = 15;
                    
                    break;
                case ClassType.Mage:
                    Health = 100;
                    AttackPower = 10;
                    Intelligent = 35;
                    break;
            }
        }
    }
}


