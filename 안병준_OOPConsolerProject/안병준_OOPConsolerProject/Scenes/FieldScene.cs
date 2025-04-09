using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using 안병준_OOPConsolerProject.GameObjPotal;

namespace 안병준_OOPConsolerProject.Scenes
{
    public class FieldScene : Scene
    {
        private ConsoleKey key;
        
        private string[] mapData;
        private bool[,] map;

        private List<GameObject> gameObjects;
        
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
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Eidos("Eidos", 'E', new Vector2(10, 29)));
            gameObjects.Add(new Light("Light", 'L', new Vector2(6, 55)));
            gameObjects.Add(new Chaos("Chaos", 'C', new Vector2(4, 37)));
            gameObjects.Add(new Abyss("Abyss", 'A', new Vector2(2, 18)));
            gameObjects.Add(new Castle("Castle", 'D', new Vector2(18, 18)));

            Game.Player.position = new Vector2(18, 56);
            Game.Player.map = map;
        }
        
        public override void Render()
        {
            PrintMap();
            foreach(GameObject obj in gameObjects)
            {
                obj.PrintObject();
            }
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("===================================================================");
            Console.WriteLine("E : Stage 1, L : Stage 2 , C : Stage 3, A : stage 4, D:Fianal Stage");
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
            foreach(GameObject obj in gameObjects)
            {
                if (Game.Player.position.x == obj.position.x &&
                    Game.Player.position.y == obj.position.y)
                {
                    obj.Interact(Game.Player);
                }
            }
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
        private void PrintText(string text)
        {
            Console.Write(text);
        }
    }
}
