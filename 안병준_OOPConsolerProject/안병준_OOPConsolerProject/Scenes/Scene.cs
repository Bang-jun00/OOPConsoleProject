using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    
    //기획하면서 생각하다보니
    //scene이 너무 많아진 것 같아 추상클래스써서
    //나머지 만들어질 scene들에서 구현
    public abstract class Scene
    {
        //Scene들마다 키 입력 필요할테니
        //protected로 자식클래스만 쓰게해서
        //Consolekey 변수 선언하기
        protected ConsoleKey key;

        public abstract void Render();
        public abstract void Input(); 
        public abstract void Update(); 
        public abstract void Result(); 

    }
}
