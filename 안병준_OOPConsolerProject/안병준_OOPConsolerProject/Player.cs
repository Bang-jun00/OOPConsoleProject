using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject
{
    

    public class Player
    {
        
        

        //플레이어의 움직임을 담당
        public Vector2 position;
        public bool[,] map;


        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine('★');
            Console.ResetColor();
        }
        
        public void Move(ConsoleKey key)
        {
            Vector2 targetPos = position;
            
            switch (key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    targetPos.y--;
                    break;
                
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    targetPos.y++;
                    break;
                
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    targetPos.x--;
                    break;
                
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    targetPos.x++;
                    break;
            }
            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
   }
}

