using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class CreatCharacterScene : Scene
    {
        private string nickname;
        private ClassType selectedClass = ClassType.None;
        private Player player;
        public override void Render()
        {
            
            Console.WriteLine("============================ 캐릭터 생성 ============================\n");
        }   
            
        public override void Input()
        {
            Console.Clear();
            Console.Write("모험가님의 여정을 시작 할 캐릭터의 닉네임을 입력하세요 : ");
            nickname = Console.ReadLine();

            while (selectedClass == ClassType.None)
            {
                selectedClass = ChooseClass();
                if (selectedClass == ClassType.None)
                {
                    Console.WriteLine("잘못된 선택입니다. 다시 입력해주세요.");
                }
            }
                
        }

        public override void Update()
        {
            player = new Player(nickname, selectedClass);
        }

        public override void Result()
        {
            Console.WriteLine($"\n{player.Nickname} 모험가님의 캐릭터가 생성되었습니다!");
            Console.WriteLine($"직업: {player.CharacterClass}");
            Console.WriteLine($"공격력: {player.AttackPower} | 체력: {player.Health}\n\n");
            Console.WriteLine(" 성역 에이도스로 이동합니다. ");

            Console.WriteLine("\n▶ 아무 키나 눌러 계속 진행하세요.");
            Console.ReadKey(true);
        }
        private ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요 : ");
            Console.WriteLine("1. 전사 (Warrior)");
            Console.WriteLine("2. 마법사 (Mage) ");
            Console.Write("선택 :  ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    return ClassType.Warrior;
                case "2":
                    return ClassType.Mage;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    return ClassType.None;
            }
        }







    }
}
