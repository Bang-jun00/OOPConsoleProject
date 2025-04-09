using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject
{
    //직업 열거형
    public enum ClassType
    {
        None = 0,
        Warrior = 1,
        Mage = 2
    }

    public class PlayerInform
    {
        public string Nickname { get; set; }
        public ClassType CharacterClass { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

       

        public PlayerInform(string nickName, ClassType characterClass)
        {
            Nickname = nickName;
            CharacterClass = characterClass;
            SetStats();
        }

        
        private void SetStats()
        {
            switch (CharacterClass)
            {
                case ClassType.Warrior:
                    Health = 150;
                    AttackPower = 25;
                    
                    break;
                case ClassType.Mage:
                    Health = 140;
                    AttackPower = 20;
                    
                    break;
                default:
                    Health = 0;
                    AttackPower = 0;
                    break;
            }
        }
    }
}
