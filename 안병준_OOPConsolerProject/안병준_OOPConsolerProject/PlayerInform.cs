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

    public class PlayerInform
    {
        public string Nickname { get; set; }
        public ClassType CharacterClass { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public int Intelligent { get; set; }

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
                    AttackPower = 30;
                    Intelligent = 15;
                    break;
                case ClassType.Mage:
                    Health = 100;
                    AttackPower = 15;
                    Intelligent = 30;
                    break;
                default:
                    Health = 0;
                    AttackPower = 0;
                    break;
            }
        }
    }
}
