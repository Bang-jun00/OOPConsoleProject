using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class EndingScene2 : Scene
    {
        public override void Render()
        {
            Print("노아는 당신의 눈을 바라보며 조용히 고개를 끄덕였습니다.");
            Print("사실 힘은 남아 있었지만, 그는 더 이상 싸울 이유가 없다는 듯이 칼을 내려놓습니다.");
            Print("");
            Print("노아 : 나를 죽이지 않겠다는 선택... 쉽지 않았을 텐데 말이다.");
            Print("");
            Print("당신은 봉인의 의식을 준비하며, 노아의 마지막 말을 들었습니다.");
            Print("");
            Print("노아 : 어둠이 사라지면 빛도 의미를 잃는다...");
            Print("노아 : 그것이 세계의 진실이자 법칙이더군..");
            Print("노아 : 누군가는 어둠을 짊어져야만 이 세상이 유지될 것이다...");
            Print("");
            Print("당신은 마법진을 펼치고, 균형의 힘으로 노아를 봉인합니다.");
            Print("봉인이 되기 전 노아는 모험가에게 이야기 합니다.");
            Print("");
            Print("뒤를 부탁한다 모험가, 내가 다시 부활할 세상에도 그대같은 모험가가 있엇으면 좋겠군..");
            Print("노아는 마지막까지 미소를 머금은 채, 조용히 봉인되었습니다.");
            Print("");
            Print("모험가 : 그는 악이 아니었다... 그는 진실을 감내한 자였다.");
            Print("모험가 : 그를 봉인한 지금, 나는 그의 결심을 이어가야만 한다.");
            Print("");
            Print("이후 세상은 눈부신 평화를 맞이했지만...");
            Print("당신은 종종, 어둠 너머에서 들려오는 속삭임을 느끼곤 합니다.");
            Print("그것은 균형이 무너질 날이 다가오고 있음을 암시하는 경고였습니다.");
            Print("");
            Print("당신은 결심합니다. 필요하다면... 나 역시 어둠을 짊어지리라.");
            Print("");
            Console.WriteLine();
            Console.WriteLine();
            Print("ENDING 2 : 『균형의 수호자』");
            Console.WriteLine("세상의 어둠을 짊어진 영웅을 쓰러뜨리는 대신, 봉인한 당신.");
            Console.WriteLine("진실을 이해한 자로서, 당신은 새로운 균형의 수호자가 되었습니다.");
        }

        public override void Input()
        {
            Console.WriteLine("\n ▶ [Enter]를 눌러 게임을 종료합니다.");
            Console.ReadKey(true);
        }

        public override void Update()
        {
            
        }

        public override void Result ()
        {
            Game.End();
        }
    }
}
