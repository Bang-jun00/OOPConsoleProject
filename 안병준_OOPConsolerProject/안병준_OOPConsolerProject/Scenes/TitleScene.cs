using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("=============================================================================");
            Console.WriteLine("                  _   _ ___ ____ _____ ___  ____  ___    _    ");
            Console.WriteLine("                 | | | |_ _/ ___|_   _/ _ \\|  _ \\|_ _|  / \\   ");
            Console.WriteLine("                 | |_| || |\\___ \\ | || | | | |_) || |  / _ \\  ");
            Console.WriteLine("                 |  _  || | ___) || || |_| |  _ < | | / ___ \\ ");
            Console.WriteLine("                 |_| |_|___|____/ |_| \\___/|_| \\_\\___/_/   \\_\\");
            Console.WriteLine("                                                               ");
            Console.WriteLine("                     ◆ The coexistence of good and evil ◆              ");
            Console.WriteLine("                                                               ");
            Console.WriteLine("                   Press [Enter] to start | Press [Q] to quit  ");
            Console.WriteLine("=============================================================================");
        }
            
        public override void Input()
        {
            key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Historia의 세계로 이동합니다.");
                    break;
                case ConsoleKey.Q:Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(0);
                    break;

            }    
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
