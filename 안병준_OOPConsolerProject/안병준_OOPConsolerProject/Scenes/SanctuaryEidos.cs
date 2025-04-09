using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class SanctuaryEidos : Scene
    {
        private string choice;
        public override void Render()
        {
            Console.WriteLine($"\n현재 능력치:");
            Console.WriteLine($"체력         : {Game.playerInform.Health}");
            Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
            Console.WriteLine($"지능         : {Game.playerInform.Intelligent}\n");

            Print("이 아름다운 곳은 성역 에이도스");
            Print("영웅을 찾는 여정을 시작한 당신은 이 곳에 도착해 재정비를 한다.\n");                        
            Print("에이도스에서 무엇을 하시겠습니까?\n");
            
            Print(" 1. 성역의 도서관에서 노아의 흔적이 담긴 고서를 뒤적인다.(지능 5+)");
            Print(" 2. 무기를 들고 훈련장으로 향한다.(공격력 5+)");
            Print(" 3. 성역의 신관에게 축복을 받는다.(체력 10+)");
            Print(" 4. 성역을 등지고 미지의 길로 나아간다.(아무 능력치도 받지 않고 떠나기)\n");
            
            Console.Write("선택 :   ");
        }

            

            

         

        public override void Input()
        {
            choice = Console.ReadLine();
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            while(true)
            {
                switch(choice)
                {
                    case "1":
                        Print("당신은 조용한 성역의 도서관으로 발걸음을 옮겼습니다.");
                        Print("빛바랜 책장들 사이에 먼지가 자욱한 고서를 한 권 꺼내듭니다.");
                        Print("책에는 '노아'라는 이름이 자주 등장합니다... 그의 여정은 수수께끼로 가득 차 있엇죠.");
                        Print("당신의 지능이 5만큼 증가했습니다.");
                        Game.playerInform.Intelligent += 5;
                        Print("");
                        Print($"체력         : {Game.playerInform.Health}");
                        Print($"공격력       : {Game.playerInform.AttackPower}");
                        Print($"지능         : {Game.playerInform.Intelligent}");
                        Game.ChangeScene("");
                        break;
                        
                    case "2":
                        Print("훈련장의 모래바닥은 이미 수많은 전사들의 피와 땀을 먹은 듯 합니다.");
                        Print("당신은 무기를 집어 들고, 여러 동작을 반복하며 단련합니다.");
                        Print("시간이 지날수록 무기가 손에 익고, 몸은 점점 전투에 익숙해져 갑니다.");
                        Print("당신의 공격력이 5만큼 증가했습니다.");
                        Game.playerInform.AttackPower += 5;
                        Print("");
                        Print($"체력         : {Game.playerInform.Health}");
                        Print($"공격력       : {Game.playerInform.AttackPower}");
                        Print($"지능         : {Game.playerInform.Intelligent}");
                        
                        break;
                    case "3":
                        Print("당신은 성소를 향해 무릎을 꿇습니다.");
                        Print("눈을 감는 순간, 따뜻한 빛이 몸을 감싸고, 지친 마음과 육신이 회복 되는 느낌을 받습니다.");
                        Print("성스러운 기운이 혈관을 타고 흐르며, 당신의 육체에 생기를 불어넣습니다.");
                        Print("당신의 체력이 10만큼 증가했습니다.");
                        Game.playerInform.Health += 10;
                        Print("");
                        Print($"체력         : {Game.playerInform.Health}");
                        Print($"공격력       : {Game.playerInform.AttackPower}");
                        Print($"지능         : {Game.playerInform.Intelligent}");

                        break;



                }
            }
        }
        
        
        
        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("   ____                       ___                 ");
            Console.WriteLine("  / ___| __ _ _ __ ___   ___ / _ \\__   _____ _ __ ");
            Console.WriteLine(" | |  _ / _` | '_ ` _ \\ / _ \\ | | \\ \\ / / _ \\ '__|");
            Console.WriteLine(" | |_| | (_| | | | | | |  __/ |_| |\\ V /  __/ |   ");
            Console.WriteLine("  \\____|\\__,_|_| |_| |_|\\___|\\___/  \\_/ \\___|_|   ");
            Console.WriteLine("\n▶ [Enter]를 눌러 다시 도전합니다.");
            Console.ReadKey(true);
            Game.ChangeScene("Eidos");
        }
    }
}
