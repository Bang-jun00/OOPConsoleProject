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
            Console.Clear();
            Console.WriteLine($"\n현재 능력치:");
            Console.WriteLine($"체력         : {Game.playerInform.Health}");
            Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}\n");
            
            Print("Chapter 1. 성역 에이도스\n");
            Print("이 아름다운 곳은 성역 에이도스");
            Print("영웅을 찾는 여정을 시작한 당신은 이 곳에 도착해 재정비를 한다.\n");                        
            Print("에이도스에서 무엇을 하시겠습니까?\n");

            Console.WriteLine(" 1. 성역의 도서관에서 노아의 흔적이 담긴 고서를 뒤적인다.");
            Console.WriteLine(" 2. 무기를 들고 훈련장으로 향한다.");
            Console.WriteLine(" 3. 성역의 신관에게 축복을 받는다.");
            Console.WriteLine(" 4. 성역을 등지고 미지의 길로 나아간다.\n");
            Console.WriteLine("▶ 계속 진행하시려면 원하는 선택지를 고르고 [Enter]를 눌러주세요. ");
            Console.Write("선택 :  ");
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
            
            
            switch(choice)
            {
                case "1":
                    Console.Clear();
                    Print("당신은 조용한 성역의 도서관으로 발걸음을 옮겼습니다.");
                    Print("빛바랜 책장들 사이에 먼지가 자욱한 고서를 한 권 꺼내듭니다.");
                    Print("책에는 '노아'라는 이름이 자주 등장합니다... 그의 여정은 수수께끼로 가득 차 있엇죠.");
                    Print("아는 것이 곧 힘이라는 말이 있습니다. 당신은 지식을 습득하고 성역을 떠납니다.");
                    Print("");
                    
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                    
                    return;
                    
                case "2":
                    Console.Clear();
                    Print("훈련장의 모래바닥은 이미 수많은 전사들의 피와 땀을 먹은 듯 합니다.");
                    Print("당신은 무기를 집어 들고, 여러 동작을 반복하며 단련합니다.");
                    Print("시간이 지날수록 무기가 손에 익고, 몸은 점점 전투에 익숙해져 갑니다.");
                    Print("꾸준한 단련은 당신의 모험에 도움이 될 것 입니다.");
                    Print("당신은 단련을 마친 뒤 성역을 떠납니다.");
                    Print("");
                    
                    
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                    
                    
                    return;
                case "3":
                    Console.Clear();
                    Print("당신은 성소를 향해 무릎을 꿇습니다.");
                    Print("눈을 감는 순간, 따뜻한 빛이 몸을 감싸고, 지친 마음과 육신이 회복 되는 느낌을 받습니다.");
                    Print("성스러운 기운이 혈관을 타고 흐르며, 당신의 육체에 생기를 불어넣습니다.");
                    Print("신의 가호가 함께 하기를..");
                    Print("앞으로의 여정을 축복받으며 당신은 성역을 떠납니다.");
                    Print("");
                    
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                    
                    return;
                case "4":
                    Console.Clear();
                    Print("당신은 더 이상 이곳에 머무르지 않기로 결심합니다.");
                    Print("당신은 점점 성역을 벗어나 깊은 안개 속으로 향합니다..");
                    Print("성역은 이제 뒤편으로 사라지고,\n눈앞엔 알 수 없는 운명이 기다리고 있습니다\n.");
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                    return;
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                    Thread.Sleep(1500);
                    Game.ChangeScene("Eidos");
                    break;
            }
            
        }
    }
}


        
        
        
        
