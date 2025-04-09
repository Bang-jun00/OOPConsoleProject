using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{    
    public class TheDevilKingCastle : Scene
    {
        private string choice;
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("\n현재 능력치:");
            Console.WriteLine($"체력         : {Game.playerInform.Health}");
            Console.WriteLine($"공격력       : {Game.playerInform.AttackPower}\n");


            Print("Final Chapters. 마왕성\n");
            Print("마침내 당신은 마왕성의 옥좌 앞에 섰습니다...");
            Print("당신 앞에는 충격적이게도 그토록 찾던 영웅 노아가 서 있습니다.");
            Print("당신은 그의 표정을 바라보았습니다.");
            Print("그의 표정에는 슬픔과 결의가 공존하고 있습니다...\n");
            Console.WriteLine("▶ 계속 진행하시려면 [Enter]를 눌러주세요. ");
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
            Console.Clear();
            if(Game.playerInform.Health >= 40 &&
                Game.playerInform.AttackPower >= 40)
            {
                
                Print("노아는 말없이 무기를 들어 올립니다...");
                Print("그 와의 전투가 시작 됐습니다.");
                Print("치열한 공방 끝에 당신은 노아를 무력화 시킵니다.");
                Print("");
                Console.Clear();

                Console.WriteLine("\n당신의 선택은..?");
                Console.WriteLine("1. 마왕 노아를 처치한다. (Ending1)");
                Console.WriteLine("2. 마왕 노아를 봉인한다. (Ending2)\n");
                
                Console.WriteLine("▶ 계속 진행하시려면 원하는 선택지를 고르고 [Enter]를 눌러주세요. ");
                Console.Write("선택 : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Game.ChangeScene("Ending1");
                        break;
                    case "2":
                        Game.ChangeScene("Ending2");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                        Thread.Sleep(1000);
                        Game.ChangeScene("Castle");
                        break;
                }
                
                
            }
            else
            {
                Print("당신의 몸은 이미 전투를 감당할 수 없을 만큼 지쳐 있습니다......");
                Print("마왕에게서 뿜어져 나오는 기운만으로도 당신은 버틸 수 없습니다...");
                Print("당신은 결국 싸워보기도 전에 견디지 못하고 쓰러지고 맙니다...");
                GameOver();
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
            Game.ChangeScene("Title");
        }
    }
}
