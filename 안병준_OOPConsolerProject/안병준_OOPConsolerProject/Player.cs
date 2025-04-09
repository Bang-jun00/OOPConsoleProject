using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject
{
    //직업 타입 열거형
    public enum ClassType
    {
        None = 0,
        Warrior = 1,
        Mage = 2
    }
    public class Player
    {
        //생성된 플레이어 캐릭터의 이름, 직업, 스텟등의 정보
        public string Nickname { get; set; }
        public ClassType CharacterClass { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Intelligent { get; set; }
        public Player(string nickname, ClassType characterClass)
        {
            Nickname = nickname;
            CharacterClass = characterClass;
            Setstats();
        }
        private void Setstats()
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
                    AttackPower = 10;
                    Intelligent = 35;
                    break;
            }
        }

        //플레이어의 움직임을 담당
        public Vector2 position;
        public bool[,] map;


        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine('★');
            Console.ResetColor();
        }
        
        public void Move(ConsoleKey key)
        {
            Vector2 targetPos = position;
            
            switch (key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    targetPos.y--;
                    break;
                
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    targetPos.y++;
                    break;
                
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    targetPos.x--;
                    break;
                
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    targetPos.x++;
                    break;
            }
            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
   }
}

