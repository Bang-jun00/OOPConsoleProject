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
        //게임 진행시 필요한 정보.
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        private static bool gameOver;

        
       
        public static void Run()
        {
            Start();
            
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
                

            End();
        }
        

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
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
            sceneDic.Add("Prologue", new PrologueScene());
            sceneDic.Add("Character", new CreatCharacterScene());
            
            
            //초기 씬을 타이틀로 설정
            curScene = sceneDic["Title"];
            
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
