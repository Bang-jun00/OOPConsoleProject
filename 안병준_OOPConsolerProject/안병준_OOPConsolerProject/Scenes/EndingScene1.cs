using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class EndingScene1 : Scene
    {
        public override void Render()
        {
            Print("노아는 사실 힘이 더 남아있엇지만 저항하지 않았습니다.");
            Print("당신의 공격을 가슴에 맞은 순간, 그는 오히려 안도한 듯 웃었습니다.");
            Print("");
            Print("노아 : 고맙다..네가 이 역할을 끝내줄 줄 알았다.");
            Print("");
            Print("쓰러지기 전, 노아는 세계의 진실을 전합니다.");
            Print("");
            Print("노아 : 어둠이 사라지면...빛 또한 무너진다..\n 내가 마왕이 된 건..그 균형을 유지하기 위해서였지...");
            Print("노아 : 이 이후는 나도 어떻게 될지 모르겠구나..뒤를 부탁하마..");
            Print("");
            Print("그렇게 한 때 영웅이라 칭송받던 마왕 노아는..세계의 진실을 전하고 모험가에게 뒤를 맡기며 눈을 감았습니다..");
            Print("");
            Print("모험가 : 마왕은 죽었지만, 세계의 균형은 무너졌다.");
            Print("모험가 : 그 이후 세상은 잠시 평화를 맞았지만,\n 이상할 정도로 모든 이들의 의지가 흐려지기 시작했다.");
            Print("모험가 : 빛이 넘칠수록 그림자가 필요하듯,\n 난 아직도 내가 원하던 결말이 맞았는지, 내게 되묻는다.");
            Print("");
            Console.WriteLine();
            Console.WriteLine();
            Print("ENDING 1 : 『균형을 끊은 자』");
            Console.WriteLine("당신은 그토록 찾던 영웅을 찾았지만, 세계의 진실로 인하여 마왕이 된 그를 본인의 손으로 죽이고 말았습니다.");
            Console.WriteLine("어둠이 없어지고 세상이 평화로워졌지만, 어딘가..비어있습니다.");
        }
            


        public override void Input()
        {
            Console.WriteLine("\n ▶ [Enter]를 눌러 게임을 종료합니다.");
            Console.ReadKey(true);
            
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            Game.End();
        }
    }
}
