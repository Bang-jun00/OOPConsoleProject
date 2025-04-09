using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class SanctuaryOfLight : Scene
    {

        private string choice;
        public override void Render()
        {
            Console.WriteLine("\n현재 능력치:");
            Console.WriteLine($"체력         : {Game.playerInform.Health}");
            Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}\n");

            Print("Chapter2. 빛의 관문\n");
            Print("빛으로 가득한 이 장소는 노아가 마지막으로 모습을 드러낸 곳.");
            Print("신성하고 고요한 이곳에선, 숨겨진 진실이 속삭이고 있다.\n");
            Print("빛의 관문에서 무엇을 하시겠습니까?\n");

            Console.WriteLine(" 1. 빛의 마법진에 손을 댄다.");
            Console.WriteLine(" 2. 수호자의 눈을 응시한다.");
            Console.WriteLine(" 3. 수호자를 따라 관문의 중심지로 간다.\n");

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
                    Print("당신은 마법진에 손을 갖다 댑니다.");
                    Print("그 순간 마법진에서 강렬한 빛이 나와 당신에게 영향을 끼칩니다.");
                    Print("당신은 고통을 견디며 마법진을 봉인해냈습니다...");
                    Print("체력이 20 감소합니다.");
                    Print("");
                    
                    Game.playerInform.Health -= 20;
                    
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                
                    break;
                
                
            
                case "2":
                    Console.Clear();
                    Print("빛의 수호자는 당신의 내면을 꿰뚫는 듯한 시선을 보냅니다.");
                    Print("그는 아무 말 없이 등을 돌리고 떠납니다.");
                    Print("그의 눈빛 속엔 슬픔이 맺혀 있엇지만, 당신은 끝내 이해하지 못했습니다.");
                    Print("");
                    
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000); 
                    Game.ChangeScene("Field");
                    break;
                
                case "3":
                    Console.Clear();
                    Print("수호자는 말없이 당신을 성역의 중심지로 인도합니다.");
                    Print("수호자는 당신에게 중요한 것은 내면의 단련이라며 이야기 합니다.");
                    Print("당신은 중심지에서 넘치는 성스러운 기운을 느끼며, 내면의 단련을 마칩니다.");
                    Print("공격력이 5 증가합니다.");
                    Print("");
                    
                    Game.playerInform.AttackPower += 5;
                    
                    Console.WriteLine($"체력         : {Game.playerInform.Health}");
                    Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}");
                    Thread.Sleep(2000);
                    Game.ChangeScene("Field");
                    break;
            
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                    Thread.Sleep(1500);
                    Game.ChangeScene("Light");
                    break;





            }
        }
    }
}                                                                                                                                               
                        
                        


                        
                        
        