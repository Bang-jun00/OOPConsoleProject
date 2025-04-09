using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class BorderOfChaos : Scene
    {
        private string choice;
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("\n현재 능력치:");
            Console.WriteLine($"체력         : {Game.playerInform.Health}");
            Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}\n");


            Print("Chapter3. 혼돈의 경계\n");
            Print("바람은 불길하고, 대지는 짐승의 울음으로 울리고 있다.");
            Print("영웅이 사라진 지금, 이곳은 혼란만이 남은 잊혀진 경계다.\n");
            Print("혼돈의 경계에서 무엇을 하시겠습니까?\n");

            Console.WriteLine(" 1. 앞길을 가로 막는 혼돈의 짐승과 싸운다.");
            Console.WriteLine(" 2. 연기가 피어오르는 폐허를 조사한다.");
            Console.WriteLine(" 3. 붉게 물든 깃발을 조사한다.\n");

            Console.WriteLine("▶ 계속 진행하시려면 원하는 선택지를 고르고 [Enter]를 눌러주세요. ");
            Console.Write("선택 : ");
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


            
            
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Print("혼돈의 짐승은 당신의 앞길을 가로 막았습니다.");
                    Print("그러나, 당신은 굴하지 않고 혼돈의 짐승과 싸워 승리했습니다.");
                    Print("혼돈의 짐승과 싸우며 무기를 다루는 실력이 더욱 능숙해졌습니다.");
                    Print("공격력이 7 증가합니다.");
                    Print("");
                    
                    Game.playerInform.AttackPower += 7;
                    
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                    break;





                case "2":
                    Console.Clear();
                    Print("당신은 연기가 피어나는 폐허의 잔해를 조사하러 갔습니다.");
                    Print("바닥이 뜨거워 지더니 폐허의 잔해에서 불기둥이 솓아났습니다.");
                    Print("당신은 매우 고통스러워 합니다.");
                    Print("체력이 30 감소합니다.");

                    Game.playerInform.Health -= 30;
                    
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                    break;
                
                case "3":
                    Console.Clear();
                    Print("당신은 부서진 창과 함께 꽂힌 붉은 깃발을 발견합니다.");
                    Print("깃발은 오래되었고, 누군가 피로 써내린 듯한 문장이 희미하게 보입니다.");
                    Print("그러나 문장을 해석할 수 없었고, 당신은 무언가 중요한 것을 놓친 느낌을 받습니다.");
                    Print("");
                    Print("당신은 조용히 자리를 떠납니다.");
                    
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                    break;
                
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                    Thread.Sleep(1500);
                    Game.ChangeScene("Chaos");
                    break;
            }
            
        }
    }
}      