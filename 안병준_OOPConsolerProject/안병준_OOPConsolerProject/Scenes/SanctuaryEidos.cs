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
        public override void Render()
        {
            Print("이 아름다운 곳은 성역 에이도스");
            Print("영웅을 찾는 여정을 시작하기 전 당신은 이곳에서 대비를 해야한다.\n");

            Console.WriteLine("어떤 대비를 하시겠습니까?");
            Print(" 1. 성역의 도서관에서 노아에 대한 기록을 찾는다.");
            Print(" 2. 성역의 훈련장에서 전투훈련을 한다.");
            Print(" 3. 성역의 소문난 맛집에서 든든하게 배를 채운다.\n");

            Console.Write("선택 :   ");
            string choice = Console.ReadLine();

        }
         

        public override void Input()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }
    }
}
