using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class AbyssofTruth : Scene
    {
        private string choice;
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("\n현재 능력치:");
            Console.WriteLine($"체력         : {Game.playerInform.Health}");
            Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}\n");


            Print("Chapter4. 어둠의 심연\n");
            Print("빛마저 스스로 사라지려 하는 이곳,");
            Print("깊고 깊은 어둠 속에서 영웅의 진실과 세계의 균형을 찾을 수 있을까?\n");
            Print("어둠의 심연에서 무엇을 하시겠습니까?\n");

            Console.WriteLine(" 1. 희미한 빛이 나는 길을 따라간다.");
            Console.WriteLine(" 2. 바닥에 떨어진 빛나는 장신구를 조사한다.");
            Console.WriteLine(" 3. 앞에 성문이 있다. 성문으로 들어간다.\n");

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
                    
                    
                    Print("당신은 희미한 빛이 나는 길을 발견했습니다.");
                    Print("희미한 빛의 나는 길을 따라가서 길의 끝에 당도했습니다.");
                    Print("그때 빛이 꺼지며 끝없는 어둠이 당신을 집어 삼킵니다.");
                    Print("당신은 몸부림 치며 겨우 어둠에서 빠져 나왔습니다.");
                    Print("체력이 30 감소합니다.");
                    Print("");
                    
                    Game.playerInform.Health -= 30;

                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                        
                    break;
                    
                case "2":
                    Console.Clear();
                    Print("당신은 바닥에 있는 빛나는 장신구를 손에 움켜쥐었습니다.");
                    Print("빛나는 장신구에서 성스러운 힘이 느껴집니다.");
                    Print("성스러운 힘이 당신에게 스며들었습니다.");
                    Print("공격력이 10 증가합니다.");
                    Print("");

                    Game.playerInform.AttackPower += 10;

                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                    
                    break;

                case "3":
                    Console.Clear();
                    Print("당신은 심연을 돌아다니다 사악한 기운이 흘러나오는 성문을 발견했습니다.");
                    Print("마왕의 성의 문으로 보이는 곳이었고 당신은 두려웠지만 앞으로 나아갑니다.");
                    Print("");

                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");

                    break;
                
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                    Thread.Sleep(1000);
                    Game.ChangeScene("Abyss");
                    break;
            }
            
        }
    }
}
                        






        
