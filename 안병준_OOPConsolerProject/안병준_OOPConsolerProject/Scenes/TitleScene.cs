﻿using System;
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
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            while (true)
            {
                switch (key)
                {
                    case ConsoleKey.Enter:
                        Console.WriteLine("Historia의 세계로 이동합니다...");
                        Thread.Sleep(1500);
                        Console.Clear();
                        Game.ChangeScene("Prologue");
                        return;
                    case ConsoleKey.Q:
                        Console.WriteLine("게임을 종료합니다.");
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("잘못된 입력입니다. 다시 선택해주세요");
                        key = Console.ReadKey(true).Key;
                        break;
                }
            }
        }
    }
}
                


