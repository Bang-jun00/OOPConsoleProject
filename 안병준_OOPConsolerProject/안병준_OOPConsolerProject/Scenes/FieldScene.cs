using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class FieldScene : Scene
    {
        private ConsoleKey key;
        private string[] mapData;
        private bool[,] map;
        
        public FieldScene()
        {
            mapData = new string[]
            {
            "############################################################",
            "#                    #             ## ##                   #",
            "#  ##               #             ##   ##                  #",
            "#  ##              #             ##     ##                 #",
            "#   ## # # # # #  #             ##       ##                #",
            "#   ##                          ##       ##      ###########",
            "#   ##                           ##     ##       ##       ##",
            "#   ##                                           ##       ##",
            "#   ##                                           ######   ##",
            "#   ##                  ##############                     #",
            "#   ##                  ##          ##                     #",
            "#   ##                  ##          ##                     #",
            "#   ##                  #####    #####                     #",
            "#     #     #                                              #",
            "#      #   # #                                             #", 
            "#       # #   #   #                                        #",
            "#        #     # # #                                       #",
            "#                   #                                      #",
            "#                    #                                     #",
            "############################################################"
            };



            map = new bool[20,60];

            for(int y =0; y < map.GetLength(0); y++)
            {
                for(int x = 0; x < map.GetLength(1); x++)
                {
                    map[y,x] = mapData[y][x] == '#'? false : true;
                }
            }
           
            Game.Player.position = new Vector2(18, 56);
            Game.Player.map = map;
        }
        
        public override void Render()
        {
            PrintMap();
            Console.WriteLine("E : Stage 1, L : Stage 2 , C : Stage 3, A : stage 4, K:Fianal Stage");
            Game.Player.PrintPlayer();
        }

        public override void Input()
        {
            key = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            Game.Player.Move(key);
        }

        public override void Result()
        {
            
        }

        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if(map[y,x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
