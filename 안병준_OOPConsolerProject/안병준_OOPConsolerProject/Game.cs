using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 안병준_OOPConsolerProject.Scenes;

namespace 안병준_OOPConsolerProject
{
    public static class Game
    {
        private static Dictionary<string, Scene> sceneDic;
        private static Scene cutScene;

        private static bool gameOver;

        public static void Run()
        {
            Start();
            
            while (gameOver == false)
            {
                
                cutScene.Render();
                cutScene.Input();
                cutScene.Update();
                cutScene.Result();
            }

            End();
        }
        /// <summary>
        /// 게임 시작 작업 진행
        /// </summary>
        
        private static void Start()
        {
            //게임 설정
            gameOver = false;

            //씬 설정
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title",new TitleScene());

            //초기 씬을 타이틀로 설정
            cutScene = sceneDic["Title"];
            
        }

        /// <summary>
        /// 게임의 마무리 진행 
        /// </summary>
        private static void End()
        {
            gameOver = true;
        }
    }

}
