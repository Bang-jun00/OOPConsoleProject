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
            Print("이 아름다운 곳은 성역 에이도스");
            Print("영웅을 찾는 여정을 시작한 당신은 이 곳에 도착해 재정비를 한다.\n");

            Console.WriteLine("에이도스에서 무엇을 하시겠습니까?");
            Print(" 1. 성역의 도서관에서 노아에 대한 기록을 찾는다.");
            Print(" 2. 성역의 훈련장에서 전투훈련을 한다.");
            Print(" 3. 성역의 신관에게 축복을 받는다.");
            Print(" 4. 마을을 떠난다.");

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
                        Game.Player


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
