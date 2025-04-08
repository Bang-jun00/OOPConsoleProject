using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class PrologueScene : Scene
    {
        
        public override void Render()
        {
            Print("이 이야기의 시작은 영웅 노아의 전설에서 시작된다.\n");
            Print("세상은 오랜 시간 어둠에 잠겨 있엇다.\n");
            Print("마왕 비스트는 온 세상을 공포로 몰아넣고, 사람들의 희망을 짓밟고 유린하였다.\n");
            Print("그때, 한 사람이 나타났다. 그의 이름은 노아,\n그는 수많은 시련을 이겨내며 마왕의 성으로 향하였고 마침내 마왕을 쓰러뜨리게 된다.\n");
            Print("세상을 다시 빛을 되찾았고, 노아는 영웅으로 불리게 된다.\n");
            Print("그러나, 승리의 환호도 잠시...");
            Print("그는 마왕을 쓰러뜨린 직후, 자취를 감췄다.\n");
            Print("누구도 그가 어디로 갔는지, 왜 떠났는지 알지 못하였고\n");
            Print("어떤 이는 그의 행방에 대해 죽었다 말했고, \n또 어떤 이는 그가 진정한 악을 보았고 또 다시 세상을 지키러 떠났다고 한다.\n");
            Print("그의 행방은 수수께끼로 남았고, 그 수수께끼를 풀기위해 모험가인 당신은 그를 찾아 성역 에이도스에서 여정을 시작한다.\n");
            
            
            Console.WriteLine("▶ 계속 진행하시려면 아무 키나 눌러주세요. ");
            Console.ReadKey(true);                                                                                                                        
        }
        private void Print(string text)
        {
            Console.WriteLine(text);
            Thread.Sleep(2000);
        }

            
            


        public override void Input()
        {

        }

        public override void Update()
        {

        }

        public override void Result()
        {

        }

    }
}
